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
using Warehouse.Services.Models.Product;

namespace Warehouse.Services.Controllers
{
    [RoutePrefix(WebApiConfig.API_PREFIX + "/document")]
    public class ProductController : ApiController
    {
        private static ILog _log;
        private IWarehouseManager _warehouseManager;

        public ProductController(IWarehouseManager warehouseManager)
        {
            _log = LogManager.GetLogger(this.GetType().FullName);
            _warehouseManager = warehouseManager;
        }

        [Route("{docId}/product")]
        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [SwaggerResponse(HttpStatusCode.NotFound, Type = typeof(ProductResponse))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(ProductResponse))]
        public IHttpActionResult AddProduct(int docId, ProductRequest request)
        {
            try
            {
                _log.Info("begin AddProduct");

                if (request == null)
                    throw new ArgumentNullException("The request content was null or not in the correct format");

                _warehouseManager.AddProduct(docId, Mapper.Map<Product>(request));

                return Ok(new ProductResponse() { Code = HttpStatusCode.OK, Data = request });
            }
            catch (ArgumentNullException argEx)
            {
                _log.Error(argEx);

                return BadRequest(argEx.Message);
            }
            catch (WarehouseException enEx)
            {
                _log.Error(enEx);

                return Content<ProductResponse>(HttpStatusCode.NotFound, new ProductResponse { Code = HttpStatusCode.NotFound, Message = enEx.Message });
            }         
            catch (Exception ex)
            {
                _log.Error(ex);
                return Content<ProductResponse>(HttpStatusCode.InternalServerError, new ProductResponse { Code = HttpStatusCode.InternalServerError, Message = ex.Message });
            }
        }

        [Route("{docId}/product")]
        [HttpPut]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(ProductResponse))]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [SwaggerResponse(HttpStatusCode.NotFound, Type = typeof(ProductResponse))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(ProductResponse))]
        public IHttpActionResult UpdateProduct(ProductRequest request)
        {
            try
            {
                _log.Info("begin UpdateProduct");

                if (request == null)
                    throw new ArgumentNullException("The request content was null or not in the correct format");

                _warehouseManager.UpdateProduct(Mapper.Map<Product>(request));

                return Ok(new ProductResponse() { Code = HttpStatusCode.OK, Data = request });
            }
            catch (ArgumentNullException argEx)
            {
                _log.Error(argEx);

                return BadRequest(argEx.Message);
            }
            catch (WarehouseException swEx)
            {
                _log.Error(swEx);

                return Content<ProductResponse>(HttpStatusCode.NotFound, new ProductResponse { Code = HttpStatusCode.NotFound, Message = swEx.Message });
            }        
            catch (Exception ex)
            {
                _log.Error(ex);
                return Content<ProductResponse>(HttpStatusCode.InternalServerError, new ProductResponse { Code = HttpStatusCode.InternalServerError, Message = ex.Message });
            }
        }

        [Route("{docId}/product/{prodId}")]
        [HttpDelete]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound, Type = typeof(ProductResponse))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(ProductResponse))]
        public IHttpActionResult RemoveProduct(int docId, int prodId)
        {
            try
            {
                _log.Info("begin RemoveProduct");

                _warehouseManager.RemoveProduct(docId, prodId);

                return Ok(new ProductResponse { Code = HttpStatusCode.OK });
            }
            catch (WarehouseException enEx)
            {
                _log.Error(enEx);

                return Content<ProductResponse>(HttpStatusCode.NotFound, new ProductResponse { Code = HttpStatusCode.NotFound, Message = enEx.Message });
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                return Content<ProductResponse>(HttpStatusCode.InternalServerError, new ProductResponse { Code = HttpStatusCode.InternalServerError, Message = ex.Message });
            }
        }

    }
}
