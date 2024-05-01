export async function getAllUserEventsFromItinerary() {
    let url = `/api/ItineraryEventApi`;
    const res = await fetch(url, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json'
        },
    });

    if (!res.ok) {
        // If the response is unauthorized or not OK, throw an error.
        const errorText = await res.text();
        throw new Error(`Error ${res.status}: ${errorText}`);
    }

    // Parse the JSON response and return.
    return await res.json();
}

export async function createNewItinerary() {
    let url = `/api/ItineraryEventApi/ItineraryEvent?itineraryTitle=${itineraryTitle}`;
    const res = await fetch(url, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json'
        },
    });

    if (!res.ok) {
        // If the response is unauthorized or not OK, throw an error.
        const errorText = await res.text();
        throw new Error(`Error ${res.status}: ${errorText}`);
    }

    // Parse the JSON response and return.
    return await res.json();
}

