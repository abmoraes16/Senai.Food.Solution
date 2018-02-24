using Microsoft.AspNetCore.Mvc;
using senai.ifood.domain.Contracts;
using senai.ifood.domain.Entities;

namespace senai.ifood.webapi.Controllers
{
    [Route("api/controller")]
    public class RestauranteController:Controller
    {
        private IBaseRepository<RestauranteDomain> _restauranteRepository;
        
        //ctor
        public RestauranteController(IBaseRepository<RestauranteDomain> restauranteRepository)
        {
            _restauranteRepository = restauranteRepository;
        }

        [HttpGet]
        public IActionResult GetAction()
        {
            return Ok(_restauranteRepository.Listar(new string[]{"ProdutosRestaurantes"}));
        }

        [HttpPost]
        public IActionResult PostAction([FromBody]RestauranteDomain Restaurante)
        {
            var resultado = (_restauranteRepository.Inserir(Restaurante));

            if(resultado>0){
                return Ok(resultado);
            }

            return NotFound();
        }

        [HttpDelete]
        public IActionResult DeleteAction([FromBody]RestauranteDomain Restaurante)
        {
            var resultado = _restauranteRepository.Deletar(Restaurante);

            if(resultado>0){
                return Ok(resultado);
            }

            return NotFound();
        }
        
        [HttpPut]
        public void PutAction()
        {
            //Given
            
            //When
            
            //Then
        }
    }
}