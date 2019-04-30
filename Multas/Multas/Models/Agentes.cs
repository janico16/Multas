using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Multas.Models {
    public class Agentes{

        [Key] //Identifica este atributo como primary key
        public int ID { get; set; }

        [Required (ErrorMessage ="O Nome é de preenchimento obrigatório.")]
        [StringLength (50, ErrorMessage ="O {0} deve ter, no máximo, {1} caracteres")]
        [RegularExpression("[A-ZÁÉÍÓÚ][a-záéíóúàèìòùãõâêîôûçñ]+(( | e | de | do | dos | da | das |-|')[A-ZÁÉÍÓÚ][a-záéíóúàèìòùãõâêîôûçñ]+)*",
            ErrorMessage = "O {0} só pode conter letras. Tem que começar com letra grande. Tem que conter pelo menos dois nomes.")]
        public string Nome { get; set; }

        [Required (ErrorMessage = "A Esquadra é de preenchimento obrigatório.")]
        [StringLength (20, ErrorMessage = "A {0} deve ter, no máximo, {1} caracteres")]
        [RegularExpression("[A-Z][a-z]+(( |-)[A-Z][a-z]+)*",
            ErrorMessage = "O {0} só pode conter letras. Tem que começar com letra grande. Tem que conter pelo menos dois nomes.")]
        public string Esquadra { get; set; }

        public string Fotografia { get; set; }

        //Lista de multas associado ao agente
        public ICollection<Multas> ListaDeMultas { get; set; }
    }
}