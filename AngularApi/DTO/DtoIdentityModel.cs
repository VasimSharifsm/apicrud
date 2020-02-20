using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularApi.DTO
{
    public class DtoIdentityModel
    {

        public string UserName { get; set; }
        public string Password { get; set; }
    }

        public class DtoIdentityToken
        {
            #region Properties
            public string access_token { get; set; }
            public string token_type { get; set; }
            public string expires_in { get; set; }
            public string refresh_token { get; set; }
            public string client_id { get; set; }
            public string issued { get; set; }
            public string expires { get; set; }
            public string userName { get; set; }
            public string userrole { get; set; }
            public string error { get; set; }
            public string error_description { get; set; }
            #endregion
        }
}