using MeiaBombaBeauty.Entities;
using MeiaBombaBeauty.Enums;

public static class CatalogoProdutos
{
    public static List<Produto> ObterTodos()
    {
        // csharpier-ignore-start
        return new List<Produto>
        {
            // Base
            new Produto("482915736", "Base Líquida Bruna Tavares BT Skin", "Bruna Tavares", CategoriaProduto.Base, 80m, 10),
            new Produto("907134825", "Base Hidra Glow Niina Secrets", "Niina Secrets", CategoriaProduto.Base, 70m, 10),
            new Produto("615829403", "Base Mascavo Soft Radiance", "Mascavo", CategoriaProduto.Base, 115m, 10),
            new Produto("111222333", "Base Maybelline Fit Me", "Maybelline", CategoriaProduto.Base, 55m, 10),
            new Produto("111222334", "Base L'Oréal Paris Infaillible", "L'Oréal", CategoriaProduto.Base, 65m, 10),
            // Pó
            new Produto("748203951", "Pó Facial Translucent Nina Makeup", "Nina Makeup", CategoriaProduto.Po, 65m, 10),
            new Produto("329847156", "Pó Solto BT Powder", "Bruna Tavares", CategoriaProduto.Po, 65m, 10),
            new Produto("560192837", "Pó Compacto Vult", "Vult", CategoriaProduto.Po, 40m, 10),
            new Produto("111222444", "Pó Banana Ruby Rose", "Ruby Rose", CategoriaProduto.Po, 35m, 10),
            new Produto("111222445", "Pó Translúcido Vult", "Vult", CategoriaProduto.Po, 30m, 10),
            // Corretivo
            new Produto("874561209", "Corretivo Líquido Mascavo Soft Blur", "Mascavo", CategoriaProduto.Corretivo, 80m, 10),
            new Produto("193748562", "Corretivo Natura Una", "Natura", CategoriaProduto.Corretivo, 65m, 10),
            new Produto("726504918", "Corretivo Bruna Tavares", "Bruna Tavares", CategoriaProduto.Corretivo, 55m, 10),
            new Produto("111222555", "Corretivo Vult", "Vult", CategoriaProduto.Corretivo, 30m, 10),
            // Blush
            new Produto("451239870", "Blush Líquido Océane", "Océane", CategoriaProduto.Blush, 45m, 10),
            new Produto("608374291", "Blush Cremoso Ruby Rose", "Ruby Rose", CategoriaProduto.Blush, 15m, 10),
            new Produto("982157643", "Blush Cremoso Contém 1g", "Contém 1g", CategoriaProduto.Blush, 60m, 10),
            new Produto("111222666", "Blush Vult Cor & Luz", "Vult", CategoriaProduto.Blush, 25m, 10),
            new Produto("111222667", "Blush Tracta", "Tracta", CategoriaProduto.Blush, 35m, 10),
            // Contorno
            new Produto("734809125", "Contorno em Stick Boca Rosa", "Boca Rosa", CategoriaProduto.Contorno, 70m, 10),
            new Produto("210498736", "Contorno BT Sculpt", "Bruna Tavares", CategoriaProduto.Contorno, 70m, 10),
            new Produto("569321804", "Contorno Ruby Rose", "Ruby Rose", CategoriaProduto.Contorno, 30m, 10),
            new Produto("111222777", "Contorno Tracta", "Tracta", CategoriaProduto.Contorno, 40m, 10),
            // Iluminador
            new Produto("713582904", "Iluminador Care Natural Beauty", "Care Natural Beauty", CategoriaProduto.Iluminador, 160m, 10),
            new Produto("248907163", "Iluminador BT Glow", "Bruna Tavares", CategoriaProduto.Iluminador, 60m, 10),
            new Produto("905713482", "Iluminador Ruby Rose", "Ruby Rose", CategoriaProduto.Iluminador, 30m, 10),
            new Produto("111222888", "Iluminador Océane Glow", "Océane", CategoriaProduto.Iluminador, 50m, 10),
            new Produto("111222889", "Iluminador Tracta", "Tracta", CategoriaProduto.Iluminador, 45m, 10),
            // Sombra
            new Produto("634198275", "Paleta de Sombras Ruby Rose", "Ruby Rose", CategoriaProduto.Sombra, 35m, 10),
            new Produto("820475319", "Paleta Niina Secrets", "Eudora", CategoriaProduto.Sombra, 95m, 10),
            new Produto("159384726", "Paleta Bruna Tavares", "Bruna Tavares", CategoriaProduto.Sombra, 115m, 10),
            new Produto("111222999", "Paleta Vult 40 Cores", "Vult", CategoriaProduto.Sombra, 75m, 10),
            // Gloss
            new Produto("472960138", "Gloss LipHoney (mel)", "Franciny Ehlke", CategoriaProduto.Gloss, 57m, 10),
            new Produto("690214857", "Gloss Fenty Beauty", "Fenty Beauty", CategoriaProduto.Gloss, 125m, 10),
            new Produto("111333222", "Gloss Ruby Rose", "Ruby Rose", CategoriaProduto.Gloss, 20m, 10),
            new Produto("111333223", "Gloss Maybelline Lifter", "Maybelline", CategoriaProduto.Gloss, 45m, 10),
            // Batom
            new Produto("381759204", "Batom Matte Maybelline", "Maybelline", CategoriaProduto.Batom, 50m, 10),
            new Produto("111333333", "Batom Vult", "Vult", CategoriaProduto.Batom, 25m, 10),
            new Produto("111333444", "Batom Natura Una", "Natura", CategoriaProduto.Batom, 45m, 10),
            new Produto("111333445", "Batom Líquido Fenty Beauty", "Fenty Beauty", CategoriaProduto.Batom, 110m, 10),
            new Produto("111333446", "Batom Ruby Rose Matte", "Ruby Rose", CategoriaProduto.Batom, 20m, 10),
             // Tônico
            new Produto("222111333", "Tônico Sallve", "Sallve", CategoriaProduto.Tônico, 60m, 10),
            new Produto("222111444", "Tônico Nivea", "Nivea", CategoriaProduto.Tônico, 30m, 10),
            new Produto("222111555", "Tônico Needs", "Needs", CategoriaProduto.Tônico, 27m, 10),
            new Produto("222111666", "Tônico Tracta", "Tracta", CategoriaProduto.Tônico, 45m, 10),
             // Sérum
            new Produto("333111222", "Sérum La Roche-Posay", "La Roche", CategoriaProduto.Sérum, 150m, 10),
            new Produto("333111333", "Sérum Principia Vitamina C", "Principia", CategoriaProduto.Sérum, 65m, 10),
            new Produto("333111444", "Sérum Vitamina C Tracta", "Tracta", CategoriaProduto.Sérum, 55m, 10),
            new Produto("333111555", "Sérum Hidratante CeraVe", "CeraVe", CategoriaProduto.Sérum, 90m, 10),
            new Produto("333111556", "Sérum Niacinamida Dermage", "Dermage", CategoriaProduto.Sérum, 85m, 10),
            new Produto("333111557", "Sérum Retinol Vichy", "Vichy", CategoriaProduto.Sérum, 130m, 10),
             // Protetor Solar
            new Produto("444111222", "Protetor Solar Needs", "Needs", CategoriaProduto.ProtetorSolar, 37m, 10),
            new Produto("444111333", "Protetor Solar Nivea Sun", "Nivea", CategoriaProduto.ProtetorSolar, 45m, 10),
            new Produto("444111444", "Protetor Solar La Roche-Posay", "La Roche", CategoriaProduto.ProtetorSolar, 95m, 10),
            new Produto("444111555", "Protetor Solar Isdin", "Isdin", CategoriaProduto.ProtetorSolar, 120m, 10),
            new Produto("444111556", "Protetor Solar Vichy", "Vichy", CategoriaProduto.ProtetorSolar, 110m, 10),
            new Produto("444111557", "Protetor Solar Sundown", "Sundown", CategoriaProduto.ProtetorSolar, 40m, 10),
             // Hidratante
            new Produto("555111222", "Hidratante La Roche-Posay", "La Roche", CategoriaProduto.Hidratante, 115m, 10),
            new Produto("555111333", "Hidratante CeraVe", "CeraVe", CategoriaProduto.Hidratante, 75m, 10),
            new Produto("555111444", "Hidratante Nivea Soft", "Nivea", CategoriaProduto.Hidratante, 30m, 10),
            new Produto("555111555", "Hidratante Neutrogena", "Neutrogena", CategoriaProduto.Hidratante, 55m, 10),
            new Produto("555111556", "Hidratante Vichy", "Vichy", CategoriaProduto.Hidratante, 95m, 10),
            new Produto("555111557", "Hidratante Eucerin", "Eucerin", CategoriaProduto.Hidratante, 85m, 10),
             // Sabonete
            new Produto("666111222", "Cleansing Oil Ruby Rose", "Ruby Rose", CategoriaProduto.Sabonete, 75m, 10),
            new Produto("666111333", "Sabonete Nivea Facial", "Nivea", CategoriaProduto.Sabonete, 30m, 10),
            new Produto("666111444", "Gel de Limpeza CeraVe", "CeraVe", CategoriaProduto.Sabonete, 65m, 10),
            new Produto("666111555", "Sabonete La Roche-Posay", "La Roche", CategoriaProduto.Sabonete, 80m, 10),
            new Produto("666111556", "Sabonete Neutrogena Deep Clean", "Neutrogena", CategoriaProduto.Sabonete, 25m, 10),
            new Produto("666111557", "Gel de Limpeza Effaclar La Roche-Posay", "La Roche", CategoriaProduto.Sabonete, 75m, 10),
             // Mascara
            new Produto("777111222", "Máscara Maybelline Sky High", "Maybelline", CategoriaProduto.Mascara, 55m, 10),
            new Produto("777111333", "Máscara L'Oréal Voluminous", "L'Oréal", CategoriaProduto.Mascara, 60m, 10),
            new Produto("777111444", "Máscara Ruby Rose", "Ruby Rose", CategoriaProduto.Mascara, 20m, 10),
             // Primer
            new Produto("888111222", "Primer Blur Tracta", "Tracta", CategoriaProduto.Primer, 50m, 10),
            new Produto("888111333", "Primer L'Oréal Studio Secrets", "L'Oréal", CategoriaProduto.Primer, 70m, 10),
            new Produto("888111444", "Primer Bruna Tavares BT Blur", "Bruna Tavares", CategoriaProduto.Primer, 90m, 10),
             // Esmalte
            new Produto("999111222", "Esmalte Colorama", "Colorama", CategoriaProduto.Esmalte, 8m, 10),
            new Produto("999111333", "Esmalte Risqué", "Risqué", CategoriaProduto.Esmalte, 10m, 10),
            new Produto("999111444", "Esmalte OPI", "OPI", CategoriaProduto.Esmalte, 65m, 10),
            new Produto("999111555", "Esmalte Impala", "Impala", CategoriaProduto.Esmalte, 7m, 10),
             // Rímel
            new Produto("999222111", "Rímel Maybelline Lash Sensational", "Maybelline", CategoriaProduto.Rimel, 55m, 10),
            new Produto("999222222", "Rímel L'Oréal Paradise", "L'Oréal", CategoriaProduto.Rimel, 60m, 10),
            new Produto("999222333", "Rímel Ruby Rose", "Ruby Rose", CategoriaProduto.Rimel, 20m, 10),
            new Produto("999222444", "Rímel Vult", "Vult", CategoriaProduto.Rimel, 25m, 10),
             // Delineador
            new Produto("999333111", "Delineador Vult", "Vult", CategoriaProduto.Delineador, 20m, 10),
            new Produto("999333222", "Delineador Maybelline Master Ink", "Maybelline", CategoriaProduto.Delineador, 45m, 10),
            new Produto("999333333", "Delineador Ruby Rose", "Ruby Rose", CategoriaProduto.Delineador, 18m, 10),
            new Produto("999333444", "Delineador NYX Epic Ink", "NYX", CategoriaProduto.Delineador, 70m, 10),
            // Fixador
            new Produto("998444111", "Fixador Ruby Rose Fix It", "Ruby Rose", CategoriaProduto.Fixador, 25m, 10),
            new Produto("998444222", "Fixador Urban Decay All Nighter", "Urban Decay", CategoriaProduto.Fixador, 180m, 10),
            new Produto("998444333", "Fixador NYX Matte Finish", "NYX", CategoriaProduto.Fixador, 85m, 10),
            new Produto("998444444", "Fixador Tracta", "Tracta", CategoriaProduto.Fixador, 55m, 10),
        };
        // csharpier-ignore-end
    }
}
