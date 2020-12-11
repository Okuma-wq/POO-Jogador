using System;

namespace POO_Jogador.Classes
{
    public class Jogador
    {
        private string nome;
        public string Nome{
            get{return nome;}
            set{nome = value;}
        }

        private string posicao;
        public string Posicao{
            get{return posicao;}
            set{posicao = value;}
        }

        private int nascimento;
        public int Nascimento{
            get{return nascimento;}
            set{nascimento = value;}
        }
        public int agora;

        private string nacionalidade;
        public string Nacionalidade{
            get{return nacionalidade;}
            set{nacionalidade = value;}
        }
       
        private double altura;
        public double Altura{
            get{return altura;}
            set{altura = value;}
        }

        private double peso;
        public double Peso{
            get{return peso;}
            set{peso = value;}
        }

        public string InformacaoDoJogador(){
            return $"Nome: {nome}\nPosição: {posicao}\nAno de nascimento: {nascimento}\nNacionalidade: {nacionalidade}\nAltura: {altura}\nPeso: {peso} ";
        }

        public int Idade(){
            return  agora - nascimento;
        }

        public string Aposentar(int Idade){
            switch (posicao)
            {
                case "defesa":
                    if (Idade >= 40)
                    {
                        return "Já está aposentado";
                    }else{
                        return $"Faltam {40 - Idade} anos para o jogador {this.nome} se aposentar";
                    }                    
                    break;
                case "meio-campo":
                    if (Idade >= 38)
                    {
                        return "Já está aposentado";
                    }else{
                        return $"Faltam {38 - Idade} anos para o jogador {this.nome} se aposentar";
                    }
                    break;
                case "atacante":
                    if (Idade >=35)
                    {
                        return "Já está aposentado";
                    }else{
                        return $"Faltam {38 - Idade} anos para o jogador {this.nome} se aposentar";
                    }
                    break;
                default:
                    return "posição inválida";
                    break;
            }
            
        }
    }
}