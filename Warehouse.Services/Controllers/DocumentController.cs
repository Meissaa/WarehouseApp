using AutoMapper;
using log4net;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Warehouse.Common.Entities;
using Warehouse.Common.Exceptions;
using Warehouse.Common.Managers;
using Warehouse.Services.Models.Document;

namespace Warehouse.Services.Controllers
{
    [RoutePrefix(WebApiConfig.API_PREFIX + "/document")]
    public class DocumentController : ApiController
    {
        private static ILog _log;
        private IWarehouseManager _warehouseManager;

        public DocumentController(IWarehouseManager warehouseManager)
        {
            _log = LogManager.GetLogger(this.GetType().FullName);
            _warehouseManager = warehouseManager;
        }

        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(DocumentResponse))]
        public IHttpActionResult GetDocuments()
        {
            try
            {
                _log.Info("begin GetDocuments");

                var characters = _warehouseManager.GetDocuments();

                return Ok(new DocumentResponse() { Code = HttpStatusCode.OK, Data = characters });
            }
            catch (Exception ex)
            {
                _log.Error(ex);

                return Content<DocumentResponse>(HttpStatusCode.InternalServerError, new DocumentResponse() { Code = HttpStatusCode.InternalServerError, Message = ex.Message });
            }
        }

        [Route("{id}")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound, Type = typeof(DocumentResponse))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(DocumentResponse))]
        public IHttpActionResult GetDocument(int id)
        {
            try
            {
                _log.Info("begin GetDocument");

                var character = _warehouseManager.GetDocumentDetails(id);

                return Ok(new DocumentResponse() { Code = HttpStatusCode.OK, Data = character });
            }
            catch (WarehouseException enEx)
            {
                _log.Error(enEx);
                return Content<DocumentResponse>(HttpStatusCode.NotFound, new DocumentResponse { Code = HttpStatusCode.NotFound, Message = enEx.Message });
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                return Content<DocumentResponse>(HttpStatusCode.InternalServerError, new DocumentResponse() { Code = HttpStatusCode.InternalServerError, Message = ex.Message });
            }
        }

        [HttpPost]
        [SwaggerResponse(HttpStatusCode.Created, Type = typeof(DocumentResponse))]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(DocumentResponse))]
        public IHttpActionResult CreateDocument(DocumentRequest request)
        {
            try
            {
                _log.Info("begin CreateDocument");

                if (request == null)
                    throw new ArgumentNullException("The request content was null or not in the correct format");

                _warehouseManager.CreateDocument(Mapper.Map<DocumentItem>(request));

                return Content<DocumentResponse>(HttpStatusCode.Created, new DocumentResponse() { Code = HttpStatusCode.Created, Data = request });
            }
            catch (ArgumentNullException argEx)
            {
                _log.Error(argEx);
                return BadRequest(argEx.Message);
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                return Content<DocumentResponse>(HttpStatusCode.InternalServerError, new DocumentResponse() { Code = HttpStatusCode.InternalServerError, Message = ex.Message });
            }
        }

        [HttpPut]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [SwaggerResponse(HttpStatusCode.NotFound, Type = typeof(DocumentResponse))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(DocumentResponse))]
        public IHttpActionResult UpdateDocument(DocumentRequest request)
        {
            try
            {
                _log.Info("begin UpdateDocument");

                if (request == null)
                    throw new ArgumentNullException("The request content was null or not in the correct format");

                _warehouseManager.UpdateDocument(Mapper.Map<DocumentItem>(request));

                return Ok(new DocumentResponse() { Code = HttpStatusCode.OK, Data = request });
            }
            catch (ArgumentNullException argEx)
            {
                _log.Error(argEx);
                return BadRequest(argEx.Message);
            }
            catch (WarehouseException enEx)
            {
                _log.Error(enEx);
                return Content<DocumentResponse>(HttpStatusCode.NotFound, new DocumentResponse() { Code = HttpStatusCode.NotFound, Message = enEx.Message });
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                return Content<DocumentResponse>(HttpStatusCode.InternalServerError, new DocumentResponse() { Code = HttpStatusCode.InternalServerError, Message = ex.Message });
            }
        }

        [Route("{id}")]
        [HttpDelete]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound, Type = typeof(DocumentResponse))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(DocumentResponse))]
        public IHttpActionResult RemoveDocument(int id)
        {
            try
            {
                _log.Info("begin RemoveDocument");

                _warehouseManager.RemoveDocument(id);

                return Ok(new DocumentResponse() { Code = HttpStatusCode.OK });
            }
            catch (WarehouseException enEx)
            {
                _log.Error(enEx);
                return Content<DocumentResponse>(HttpStatusCode.NotFound, new DocumentResponse() { Code = HttpStatusCode.NotFound, Message = enEx.Message });
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                return Content<DocumentResponse>(HttpStatusCode.InternalServerError, new DocumentResponse() { Code = HttpStatusCode.InternalServerError, Message = ex.Message });
            }
        }
    }
}
