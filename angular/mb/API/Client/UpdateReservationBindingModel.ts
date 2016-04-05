/// <reference path="api.d.ts" />

namespace API.Client {
    'use strict';




    export interface UpdateReservationBindingModel {



        "reservationId": number;



        "phoneNumber"?: string;



        "reservationTime": Date;



        "groupSize": number;



        "areas"?: string;



        "note"?: string;



        "highChair"?: boolean;



        "stroller"?: boolean;

    }




}
