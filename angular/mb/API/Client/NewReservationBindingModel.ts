/// <reference path="api.d.ts" />

namespace API.Client {
    'use strict';




    export interface NewReservationBindingModel {



        "restaurantId": number;



        "reservationTime": Date;



        "groupSize": number;



        "notificationUrl"?: string;



        "deviceType": string;



        "areas": string;



        "note"?: string;



        "highChair"?: boolean;



        "stroller"?: boolean;

    }




}
