function filterCars() {
    // Get all checked checkboxes and extract their values
    const selectedBrands = Array.from(document.querySelectorAll('input[type="checkbox"]:checked')).map((checkbox) => checkbox.value);

    // Filter the car list based on selected brands and color
    const filteredCars = model.data.cars.filter((car) => selectedBrands.includes(car.brand) && selectedBrands.includes(car.color));

    // Render the filtered list
    renderCarList(filteredCars);
}

// Attach event listeners for filtering
function setupEventListeners() {
    const brands = [...new Set(model.data.cars.map(car => car.brand))];
    const colors = [...new Set(model.data.cars.map(car => car.color))];

    brands.forEach(brand => {
        document.getElementById(brand).addEventListener("change", filterCars);
    });

    colors.forEach(color => {
        document.getElementById(color).addEventListener("change", filterCars);
    });
}


