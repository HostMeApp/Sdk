/// <reference path="api.d.ts" />

namespace API.Client {
    'use strict';




    export interface Message {



        "id"?: number;



        "waitItemId"?: number;



        "body"?: string;



        "time"?: Date;



        "origin"?: string;



        "isAutoMessage"?: boolean;



        "deliveryStatus"?: string;



        "deliveryTime"?: Date;



        "deliveryFailureReason"?: string;



        "isRead"?: boolean;

    }




}
