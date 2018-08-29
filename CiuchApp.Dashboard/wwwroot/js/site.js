﻿$(function () {
    $('table.table').Tabledit({
        url: '/api/BusinessTripsApi',
        columns: {
            identifier: [0, 'Id'],
            editable: [
                [1, 'DateFrom'],
                [2, 'DateTo'],
                [3, 'CountryId', '{ "0": "", "1": "Polska", "2": "Hiszpania", "3": "Włochy", "4": "Wielka Brytania", "5": "Francja" }'],
                [4, 'CityId', '{ "0": "", "1": "Wólka Kosowska" , "2": "Paryż" , "3": "Birnimgham" , "4": "Madryt" , "5": "Prato" }'],
                [5, 'SeasonId', '{ "0": "", "1": "WW18", "2": "WP18", "3": "WW19", "4": "WP19", "5": "WW20" }'],
                [6, 'CurrencyId', '{ "0": "", "1" : "PLN" ,"2" :"EURO" ,"3" :"FUNT" }']
            ]
        }
    });
});