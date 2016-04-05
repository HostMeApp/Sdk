/// <reference path="api.d.ts" />

namespace API.Client {
    'use strict';




    export interface Membership {



        "id"?: number;



        "membershipLevel"?: string;



        "points"?: number;



        "joinDate"?: Date;



        "status"?: string;



        "restaurant"?: RestaurantInfo;



        "isMember"?: boolean;



        "profile"?: UserProfile;

    }




}
