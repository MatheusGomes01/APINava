using System.Linq;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

public class RemoveIdPropertyDocumentFilter : IDocumentFilter
{
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        // Encontra o esquema do modelo Pessoa
        var pessoaSchema = swaggerDoc.Components.Schemas.FirstOrDefault(s => s.Key == "Pessoa").Value;

        // Remove a propriedade "Id" do esquema
        pessoaSchema.Properties.Remove("Id");
    }
}
