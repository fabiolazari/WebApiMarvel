using ApiMarvel.Services;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiMarvel.Controllers
{
    public class MarvelController : ApiController
    {
        // GET: api/Marvel
        public async Task<IHttpActionResult> Get()
        {
            RequestAPI requestAPI = new RequestAPI();
            try
            {
                return Ok(await requestAPI.CarregaDadosPersonagemMarvel());
            }
            catch (Exception ex) when (!string.IsNullOrEmpty(ex.Message))
            {
                return null;
            }
        }

        // GET: api/Marvel/5
        public async Task<IHttpActionResult> Get(string id)
        {
            RequestAPI requestAPI = new RequestAPI();
            try
            {
                return Ok(await requestAPI.CarregaDadosPersonagemMarvel(id));
            }
            catch (Exception ex) when (!string.IsNullOrEmpty(ex.Message))
            {
                return null;
            };
        }
    }
}
