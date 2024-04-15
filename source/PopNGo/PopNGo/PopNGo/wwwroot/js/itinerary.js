import {
    addNewDaySection,
    addChecklistItem,
    addNewChecklist,
    extractAndUpsertDaySectionData
} from './util/itineraryUtils.js';

document.addEventListener("DOMContentLoaded", () => {
    const accordion = document.getElementById("accordion");

    // Handle click events on accordion to delegate to specific targets
    addNewDaySection();
    accordion.addEventListener('click', function (event) {
        const target = event.target;
        if (target.closest('.add-items-btn')) {
            // Handles adding new checklist items
            addChecklistItem(target.closest('.add-items-btn'));
        } else if (target.closest('#addBoxButton')) {  // Corrected selector to match the ID used in the working version
            // Handles adding new checklists
            const checklistContainerId = target.getAttribute('data-checklist-id'); // Ensuring attribute access is directly from the clicked target
            addNewChecklist(checklistContainerId);
        }
    });

    // Focusout event listener for capturing changes in editable text areas
    accordion.addEventListener('focusout', event => {
        if (event.target.classList.contains('editable-text')) {
            // Handles data extraction and upsert when text editing is completed
            const daySectionElement = event.target.closest('.panel');
            extractAndUpsertDaySectionData(daySectionElement);
        }
    });

    // Button to add new day sections
    const addDayButton = document.getElementById("addNewDayButton");
    if (addDayButton) {
        addDayButton.addEventListener("click", addNewDaySection);
    }
});
