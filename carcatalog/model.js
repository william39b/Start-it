const model = {
    app: {
        html: document.getElementById("app"),
    },

    input: {},

    data: {
        cars: [
            { brand: "Toyota", model: "Camry", color: "Grå", year: 2012, kilometers: 128_748, transmission: "Automatisk", fuel: "Bensin", drive: "Forhjulsdrift", horsepower: 178, price: 90_000 },
            { brand: "Ford", model: "Focus", color: "Blå", year: 2013, kilometers: 120_700, transmission: "Manuell", fuel: "Bensin", drive: "Forhjulsdrift", horsepower: 160, price: 85_000 },
            { brand: "BMW", model: "3 Series", color: "Svart", year: 2014, kilometers: 112_654, transmission: "Automatisk", fuel: "Diesel", drive: "Bakhjulsdrift", horsepower: 180, price: 180_000 },
            { brand: "Volkswagen", model: "Golf", color: "Rød", year: 2016, kilometers: 80_467, transmission: "Manuell", fuel: "Bensin", drive: "Forhjulsdrift", horsepower: 150, price: 160_000 },
            { brand: "Honda", model: "Civic", color: "Hvit", year: 2017, kilometers: 72_420, transmission: "Automatisk", fuel: "Bensin", drive: "Forhjulsdrift", horsepower: 158, price: 190_000 },
            { brand: "Nissan", model: "Altima", color: "Grå", year: 2018, kilometers: 64_374, transmission: "Automatisk", fuel: "Bensin", drive: "Forhjulsdrift", horsepower: 182, price: 210_000 },
            { brand: "Mercedes-Benz", model: "GLE", color: "Blå", year: 2021, kilometers: 32_187, transmission: "Automatisk", fuel: "Diesel", drive: "Firehjulsdrift", horsepower: 255, price: 600_000 },
            { brand: "Volvo", model: "XC40", color: "Grønn", year: 2022, kilometers: 24_140, transmission: "Automatisk", fuel: "Bensin", drive: "Firehjulsdrift", horsepower: 248, price: 500_000 },
            { brand: "Toyota", model: "Corolla", color: "Svart", year: 2015, kilometers: 95_000, transmission: "Automatisk", fuel: "Bensin", drive: "Forhjulsdrift", horsepower: 132, price: 150_000 },
            { brand: "Ford", model: "Escape", color: "Hvit", year: 2019, kilometers: 50_000, transmission: "Automatisk", fuel: "Bensin", drive: "Firehjulsdrift", horsepower: 180, price: 220_000 },
            { brand: "BMW", model: "X5", color: "Grå", year: 2020, kilometers: 30_000, transmission: "Automatisk", fuel: "Diesel", drive: "Firehjulsdrift", horsepower: 265, price: 750_000 },
            { brand: "Volkswagen", model: "Passat", color: "Blå", year: 2018, kilometers: 60_000, transmission: "Automatisk", fuel: "Bensin", drive: "Forhjulsdrift", horsepower: 174, price: 200_000 },
            { brand: "Honda", model: "Accord", color: "Rød", year: 2016, kilometers: 80_000, transmission: "Automatisk", fuel: "Bensin", drive: "Forhjulsdrift", horsepower: 192, price: 190_000 },
            { brand: "Nissan", model: "Rogue", color: "Svart", year: 2020, kilometers: 25_000, transmission: "Automatisk", fuel: "Bensin", drive: "Firehjulsdrift", horsepower: 170, price: 250_000 },
            { brand: "Mercedes-Benz", model: "C-Class", color: "Blå", year: 2015, kilometers: 60_000, transmission: "Automatisk", fuel: "Diesel", drive: "Bakhjulsdrift", horsepower: 170, price: 300_000 },
            { brand: "Volvo", model: "S60", color: "Hvit", year: 2019, kilometers: 40_000, transmission: "Automatisk", fuel: "Bensin", drive: "Forhjulsdrift", horsepower: 250, price: 250_000 },
            { brand: "Toyota", model: "RAV4", color: "Grønn", year: 2018, kilometers: 35_000, transmission: "Automatisk", fuel: "Bensin", drive: "Firehjulsdrift", horsepower: 203, price: 320_000 },
            { brand: "Ford", model: "F-150", color: "Rød", year: 2021, kilometers: 15_000, transmission: "Automatisk", fuel: "Bensin", drive: "Firehjulsdrift", horsepower: 400, price: 500_000 },
            { brand: "BMW", model: "X3", color: "Grå", year: 2016, kilometers: 70_000, transmission: "Automatisk", fuel: "Diesel", drive: "Firehjulsdrift", horsepower: 240, price: 450_000 },
            { brand: "Volkswagen", model: "Tiguan", color: "Blå", year: 2017, kilometers: 55_000, transmission: "Automatisk", fuel: "Bensin", drive: "Firehjulsdrift", horsepower: 184, price: 300_000 },
            { brand: "Honda", model: "HR-V", color: "Svart", year: 2020, kilometers: 20_000, transmission: "Automatisk", fuel: "Bensin", drive: "Firehjulsdrift", horsepower: 141, price: 230_000 },
            { brand: "Nissan", model: "Sentra", color: "Hvit", year: 2019, kilometers: 30_000, transmission: "Automatisk", fuel: "Bensin", drive: "Forhjulsdrift", horsepower: 149, price: 190_000 },
            { brand: "Mercedes-Benz", model: "GLC", color: "Grønn", year: 2021, kilometers: 10_000, transmission: "Automatisk", fuel: "Diesel", drive: "Firehjulsdrift", horsepower: 255, price: 700_000 },
            { brand: "Volvo", model: "V60", color: "Rød", year: 2020, kilometers: 15_000, transmission: "Automatisk", fuel: "Bensin", drive: "Firehjulsdrift", horsepower: 250, price: 400_000 },
        ],
        
    },

};
