export let dayCount = 0; // Initialize the dayCount variable

export function addNewDaySection() {
    dayCount++;

    const dayTemplate = document.getElementById("day-section-template");
    const cloneDayTemplate = dayTemplate.content.cloneNode(true);
    const newBorderedPanel = cloneDayTemplate.querySelector(".bordered-panel");
    const collapseId = "collapseDay" + dayCount;
    const headingId = "headingDay" + dayCount;

    newBorderedPanel.querySelector(".panel").setAttribute("id", "panel-" + headingId);
    newBorderedPanel.querySelector(".panel-heading").setAttribute("id", headingId);
    newBorderedPanel.querySelector(".panel-collapse").setAttribute("id", collapseId);
    newBorderedPanel.querySelector(".panel-collapse").setAttribute("aria-labelledby", headingId);
    newBorderedPanel.querySelector("[data-bs-toggle='collapse']").setAttribute("href", "#" + collapseId);

    const panelBody = newBorderedPanel.querySelector(".panel-body");
    panelBody.setAttribute("id", "panelBody" + dayCount); // Set unique ID for each panel body

    const trashBtn = newBorderedPanel.querySelector(".trash-btn");
    trashBtn.addEventListener("click", () => removeDaySection(trashBtn.closest(".panel-heading")));
    initializeChecklistTemplate(panelBody);
    document.getElementById("accordion").appendChild(cloneDayTemplate);
}

export function removeDaySection(panelHeading) {
    const borderedPanel = panelHeading.closest(".bordered-panel");
    if (borderedPanel) {
        borderedPanel.remove();
    }
}

export function initializeChecklistTemplate(panelBody) {
    const checklistTemplate = document.getElementById("checklist-template");
    const cloneChecklistTemplate = checklistTemplate.content.cloneNode(true);

    // Assign unique ID to the Add Box button to refer to the correct panel body
    cloneChecklistTemplate.querySelector("#addBoxButton").setAttribute("data-checklist-id", panelBody.id);

    panelBody.appendChild(cloneChecklistTemplate);

    const addItemsButtons = panelBody.querySelectorAll('.add-some-items button');
    addItemsButtons.forEach(button => {
        button.addEventListener('click', function () {
            addChecklistItem(this);
        });
    });
}

export function addChecklistItem(btn) {
    const container = btn.closest('.card-body');
    const emptyItems = container.querySelectorAll('.editable-text[data-placeholder="New Item"]:empty');
    if (emptyItems.length > 0) {
        const tooltip = new bootstrap.Tooltip(btn, {
            title: 'Please fill out all existing items before adding more.',
            placement: 'top',
            trigger: 'manual'
        });
        tooltip.show();
        setTimeout(() => tooltip.hide(), 2000);
        return;
    }

    createNewItem(container);
    event.preventDefault();
    event.stopPropagation();
}

export function createNewItem(container, focus = true) {
    const newItemId = `flexCheck${container.id}-${container.children.length + 1}`;
    const div = document.createElement('div');
    div.classList.add('d-flex', 'mb-0', 'align-items-start', 'editable-text-container');
    div.innerHTML = `
        <input class="form-check-input me-2" type="checkbox" id="${newItemId}">
        <div class="editable-text pt-0 mt-0" contenteditable="true" data-placeholder="New Item"></div>
        <button class="btn btn-sm trash-btn border-0 bg-none" onclick="this.parentNode.remove()">×</button>
    `;
    container.insertBefore(div, container.querySelector('.add-some-items'));

    const editableText = div.querySelector('.editable-text');
    if (focus) editableText.focus();

    editableText.addEventListener('keydown', function (e) {
        if (e.key === 'Enter') {
            e.preventDefault();
            if (this.textContent.trim() !== '') createNewItem(container);
        }
    });
}

export function addNewChecklist(checklistContainerId) {
    const panelBody = document.getElementById(checklistContainerId).closest('.panel-body');
    if (!panelBody) {
        console.error("Day section panel body not found.");
        return;
    }

    const existingAddButton = panelBody.querySelector('#addBoxButton');
    if (existingAddButton) {
        existingAddButton.remove(); // Remove the existing button temporarily.
    }

    const checklistTemplate = document.getElementById("checklist-template");
    const cloneChecklistTemplate = checklistTemplate.content.cloneNode(true);

    const newBoxId = `${checklistContainerId}-checklist${new Date().getTime()}`; // Simulate receiving an ID from the backend after creation
    cloneChecklistTemplate.querySelector('.card-body').setAttribute('data-id', newBoxId);

    panelBody.appendChild(cloneChecklistTemplate);
    initializeChecklistTemplate(cloneChecklistTemplate.querySelector('.panel-body'));

    if (existingAddButton) {
        panelBody.appendChild(existingAddButton);
    } else {
        const newAddButton = document.createElement('button');
        newAddButton.id = 'addBoxButton';
        newAddButton.setAttribute('data-checklist-id', newBoxId);
        newAddButton.textContent = 'Add New Box';
        newAddButton.className = 'btn btn-primary';
        panelBody.appendChild(newAddButton);
    }
}


// Function to format today's date as YYYY-MM-DD
function getFormattedToday() {
    const today = new Date();
    const year = today.getFullYear();
    const month = (today.getMonth() + 1).toString().padStart(2, '0'); // JavaScript months are zero-based
    const day = today.getDate().toString().padStart(2, '0');
    return `${year}-${month}-${day}`;
}

// itineraryApi.js

async function upsertItineraryDaySection(itinerarySectionData) {
    const response = await fetch('/api/itinerarydaysections', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(itinerarySectionData)
    });
    return response.json();
}

// Function to extract data from the day section and send it to the API
export function extractAndUpsertDaySectionData(daySectionElement) {
    const checklists = Array.from(daySectionElement.querySelectorAll('.card-body')).map(checklist => {
        return {
            id: checklist.dataset.id, // Ensure IDs are being read and included
            itineraryHeader: checklist.querySelector('.editable-text').textContent,
            itineraryChecklistItems: Array.from(checklist.querySelectorAll('.editable-text-container')).map(item => ({
                id: item.dataset.id, // Include item IDs to identify existing items
                itemDescription: item.querySelector('.editable-text').textContent
            }))
        };
    });

    const itinerarySectionData = {
        id: daySectionElement.dataset.id, // Include the day section ID
        itineraryTitle: daySectionElement.querySelector('.editable-text').textContent,
        itineraryDate: getFormattedToday(),
        itineraryChecklists: checklists
    };

    console.log("Sending data:", JSON.stringify(itinerarySectionData));  // Log data being sent
    upsertItineraryDaySection(itinerarySectionData);
}