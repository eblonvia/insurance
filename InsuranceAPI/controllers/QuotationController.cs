using InsuranceAPI.controllers.dtos;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceAPI.controllers;
[ApiController]
[Route("quotes")]
public class QuotationController
{
    [HttpGet]
    [Route("simulation")]
    public ActionResult<Quotation> CalculateQuotation([FromBody]QuotationRequest quotationRequest)
    {
        
        return "Hello";
    }
    
    
    //TODO faire la méthode d'entrée
    // TODO avec les paramètres nécessaire
    //TODO Le controller doit appeler le UseCase : GetQuotation
    //TODO La classe GetQuotation doit utiliser QuotationService pour réaliser le travail
    //TODO Enregistrer la quotation en base de donnnée. 
    // Equipe Steven - Stéphane
    //TODO : @Emmanuel BLONVIA
}