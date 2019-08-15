using log4net;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security;
using System.Web.Http;
using Warehouse.Common.Exceptions.Security;
using Warehouse.Common.Managers;
using Warehouse.Services.Models.Auth;

namespace Warehouse.Services.Controllers
{
    [RoutePrefix(WebApiConfig.API_PREFIX + "/auth")]
    public class AuthController : ApiController
    {
        private static ILog _log;
        private ISecurityManager _securityManager;

        public AuthController(ISecurityManager securityManager)
        {
            _log = LogManager.GetLogger(this.GetType().FullName);
            _securityManager = securityManager;
        }

        [Route("login")]
        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(LoginResponse))]
        [SwaggerResponse(HttpStatusCode.Unauthorized, Type = typeof(LoginResponse))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(LoginResponse))]
        [AllowAnonymous]
        public IHttpActionResult Login(LoginRequest request)
        {
            try
            {
                 _securityManager.Login(request.Username, request.Password);
                return Ok(new LoginResponse { Code = HttpStatusCode.OK });
            }
            catch (LoginFailedException ex)
            {
                _log.Error(ex);
                return Content<LoginResponse>(HttpStatusCode.Unauthorized, new LoginResponse { Code = HttpStatusCode.Unauthorized, Message = ex.Message });
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                return Content<LoginResponse>(HttpStatusCode.InternalServerError, new LoginResponse { Code = HttpStatusCode.InternalServerError, Message = ex.Message });
            }
        }

        [Route("logout")]
        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(LoginResponse))]
        [SwaggerResponse(HttpStatusCode.NoContent, Type = typeof(LoginResponse))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(LoginResponse))]
        [AllowAnonymous]
        public IHttpActionResult Logout()
        {
            try
            {
                _securityManager.Logout();
                if (!_securityManager.IsUserLogged())
                {
                    return Ok(HttpStatusCode.OK);
                }

                return Content<LoginResponse>(HttpStatusCode.NoContent, null);
            }
            catch (Warehouse.Common.Exceptions.Security.SecurityException ex)
            {
                _log.Error(ex);
                return Content<LogoutResponse>(HttpStatusCode.NoContent, new LogoutResponse { Code = HttpStatusCode.NoContent, Message = ex.Message });
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                return Content<LogoutResponse>(HttpStatusCode.InternalServerError, new LogoutResponse { Code = HttpStatusCode.InternalServerError, Message = ex.Message });
            }
        }
    }
}
