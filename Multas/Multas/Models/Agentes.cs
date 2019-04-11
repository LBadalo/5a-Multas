using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Multas.Models {
   public class Agentes {

      public int ID { get; set; }

        //Obrigatoriedade do campo
      [Required(ErrorMessage ="Por favor, escreva o Nome do Agente" )]
      [RegularExpression("([A-ZÁÉÍÓÚa-záéíóúàèìòùãõâêîôûäëïöüçñ]+( |-|')?)+" , ErrorMessage = "Só pode escrever letras no nome. Comece com uma maiúscula")]
      public string Nome { get; set; }
        
      [Required(ErrorMessage = "Indique a que esquadra onde o agente trabalha.")]
      //Não recomendado
      //[RegularExpression("(Tomar|Ourém|Torres Novas|Lisboa|Leiria)")]
      public string Esquadra { get; set; }

      public string Fotografia { get; set; }

      // identifica as multas passadas pelo Agente
      public ICollection<Multas> ListaDasMultas { get; set; }

   }
}