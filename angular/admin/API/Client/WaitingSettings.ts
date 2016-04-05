/// <reference path="api.d.ts" />

namespace API.Client {
    'use strict';




    export interface WaitingSettings {



        "acceptRemoteRegistration"?: boolean;



        "enableManualHold"?: boolean;



        "maximumHoldTime"?: number;



        "positionMessages"?: Array<PositionMessage>;



        "statusMessages"?: Array<StatusMessage>;

    }




}
