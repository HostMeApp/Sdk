/// <reference path="api.d.ts" />

namespace API.Client {
    'use strict';




    export interface ManageInfoViewModel {



        "localLoginProvider"?: string;



        "userName"?: string;



        "logins"?: Array<UserLoginInfoViewModel>;



        "externalLoginProviders"?: Array<ExternalLoginViewModel>;

    }




}
