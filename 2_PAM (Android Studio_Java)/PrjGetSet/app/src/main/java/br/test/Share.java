package br.test;

public class Share {
    //método construtor - não tem void, constrói com ele | não é obrigado a declarar ele, ele fica escondido, mas todos tem (tem que ter o mesmo nome da classe)
    public Share() {

    }

    public Share(Integer n) //dentro dos parenteses é a ASSINATURA DO MÉTODO, tem um parametro
    //mudou a assinatura do método
    {

    }

    public Share(Integer n, String s) //assinatura tem dois paramentros | é flexivel criar assinaturas diferentes:
    //com parametros, já "cria" pronto, porque se tivesse uma cor, já poderia colocar no parametro pra já aparecer na tela pronto
    {
        text = n.toString();
    }
    //o objeto sh pode nascer vazio (integer n e intergern, string s) ou com o numero

    //nao pode colocar "R" no final porque classe não é ação, que é ação é o método
    //propriedade:
    private static String text; //static no sentido de compartilhar, usa isso pra compartilhar entre as telas - quando coloca static cria um session que é "text"

    //só acessa propriedade por meio de metodos (um pra ler e um pra escrever)
    //_tá aqui agora
    public void setText(String v) //_aqui primeiro
    {
        text = v; //_vem pra cá
    }

    public String getText()
    {
        return text;
    }

    //public String getText()
    //{
    //         return
    //}


}
