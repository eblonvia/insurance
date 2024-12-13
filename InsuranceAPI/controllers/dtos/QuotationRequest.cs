namespace InsuranceAPI.controllers.dtos;

public record QuotationRequest(
        int HorsePower,
        int FirstCirculationYear,
        decimal VehicleNewValue,
        decimal VehicleCurrentValue,
        int ProductCode 
    );
    
//TODO Creer une table de paramétrage pour les produits(ProductParameters) dans le quel chaque produit aura un Code et un Libellé
//TODO Creer une table de parametrage des garanties:CoverageParameters (Id, Code, Lablel)
//TODO Creer une table D'association ProductCoverage (ProductsId, CoverageId)