using System;
using System.ComponentModel.DataAnnotations;

namespace Loja_Cet_49.Dados.Entidades
{
    public class Produto
    {
        public int Id { get; set; } /* propriedades da tabela de dados de produtos, por causa do Entity Framework o ID é automatica e de valores inteiros get - leitura ; set - escrita*/


        public string Name { get; set; } /* nome do produto */

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)] /*para que o preço apareça, Em Modo MOEDA, com duas casas decimais , para que as pessoas possam escrever com mais casas */
        public decimal Price { get; set; } /*Preço do produto - nota: nao tem acentuação , cedilhados, ect...*/

        [Display(Name = "Image")]
        public string Url_Da_Imagem { get; set; } /* caminho das imagens para a pasta root - nota: não se guarda imagens nas bases de dados*/

        [Display(Name = "Last Buy")]
        public DateTime LastBuy { get; set; } /* Data da ultima compra */

        [Display(Name = "Last Sell")]
        public DateTime LastSell { get; set; } /* Data da ultima Venda */

        [Display(Name = "Available")]
        public bool Disponiblity { get; set; }/* um parametro à base de "true/false" para controlar a disponibilidade  do produto */

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)] /* Quantidade com até duas casas decimais*/
        public double Stock { get; set; }/*valores decimais caso haja*/

    }
}
