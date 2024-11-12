const appDiv = document.getElementById("app");
// Initialize the controller
function initController() {
    // Generate checkboxes and render initial car list
    generateCheckboxes();
    renderCarList(model.data.cars); // Initially render all cars

    // Setup event listeners for checkboxes
    setupEventListeners();
}

// Call initController to initialize the app
initController();
// view.js



// Generate checkboxes for brands and colors
function generateCheckboxes() {
    const brands = [...new Set(model.data.cars.map((car) => car.brand))];
    const colors = [...new Set(model.data.cars.map((car) => car.color))];

    let brandCheckbox = ``;
    let colorCheckbox = ``;

    brands.forEach((brand) => {
        brandCheckbox += /*HTML*/ `
            <input type="checkbox" id="${brand}" value="${brand}" checked>
            <label for="${brand}">${brand}</label><br>
        `;
    });

    colors.forEach((color) => {
        colorCheckbox += /*HTML*/ `
            <input type="checkbox" class="colorCheckbox" id="${color}" value="${color}" checked>
            <label for="${color}">${color}</label><br>
        `;
    });

    // Create checkboxes in the HTML
    appDiv.innerHTML = `
        <div class="checkbox-container">
            <fieldset><legend>Merke:</legend>
                <div class='brandCheckbox'>${brandCheckbox}</div>
            </fieldset>

            <fieldset><legend>Farge:</legend>
                <div class='colorCheckbox'>${colorCheckbox}</div>
            </fieldset>
        </div>
    `;

    // Create car list table
    appDiv.innerHTML += `
        <table class="car-list" id="car-list">
            <thead>
                <tr>
                    <th>Merke</th>
                    <th>Model</th>
                    <th>Farge</th>
                    <th>Årsmodel</th>
                    <th>Kjørelengde</th>
                    <th>Girkasse</th>
                    <th>Drivstoff</th>
                    <th>Hjuldrift</th>
                    <th>Hestekrefter</th>
                    <th>Pris (NOK)</th>
                </tr>
            </thead>
            <tbody></tbody>
        </table>
    `;
}

// Render the list of cars in the table
function renderCarList(cars) {
    const carListContainer = document.getElementById("car-list").getElementsByTagName("tbody")[0];

    // Clear previous car rows
    carListContainer.innerHTML = "";

    // Loop through each car and create a td with car details
    cars.forEach((car) => {
        const row = carListContainer.insertRow(); // Create a new row

        for (const value of Object.values(car)) {
            const cell = row.insertCell();
            cell.textContent = value;
        }
    });
}
