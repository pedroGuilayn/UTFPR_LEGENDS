using System.Collections.Generic;
using UnityEngine;


public class Pokemon
{
        public Pokemon(string nome, int nivel, int HP, int ataque, int defesa, List<Move> movimentos)
        {
            this.nome = nome;
            this.nivel = nivel;
            this.maxHP = HP;
            this.HP = HP;
            this.ataque = ataque;
            this.defesa = defesa;
            this.movimentos = movimentos;
        }

    public string nome;
    public int nivel;
    public int maxHP;
    public int HP;
    public int ataque;
    public int defesa;
    public List<Move> movimentos;

   


}