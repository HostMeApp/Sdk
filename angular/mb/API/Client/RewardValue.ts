/// <reference path="api.d.ts" />

namespace API.Client {
    'use strict';




    export interface RewardValue {



        "amount"?: number;



        "description"?: string;



        "discount"?: number;



        "freeMeal"?: string;



        "imageUrl"?: string;



        "type"?: RewardValue.TypeEnum;

    }


    export namespace RewardValue {













        export enum TypeEnum { 
            Discount = <any> 'Discount',
            FreeMeal = <any> 'FreeMeal',
            MoneyOff = <any> 'MoneyOff'
        }


    }



}
