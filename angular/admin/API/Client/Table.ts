/// <reference path="api.d.ts" />

namespace API.Client {
    'use strict';




    export interface Table {



        "tableNumber"?: string;



        "tableTopSize"?: number;



        "area"?: string;



        "tags"?: Array<string>;



        "reservability"?: TableAvailability;



        "waitability"?: TableAvailability;

    }




}
