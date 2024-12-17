using System.Diagnostics;
using InsuranceDomain.services;

namespace InsuranceUseCases.usecases;

public class GetQuotation
{
    private QuotationService _quotationService;

    public GetQuotation(QuotationService quotationService)
    {
        _quotationService = quotationService;
    }
    
    //TODO créer une méthode Process qui prend en paramètre les infis de la simulation et retourne une simulation
    public QuotationService ()
    {
        
    }
}