using System;

public class Aluno : Pessoa {

     public double notaProva{ get; set;}
     public double notaTrabalho{ get; set;}
     public int matricula{ get; set;}
     public double media{ get; set;}
     public Boolean liberacaoProvaRecuperacao{ get; set;}
     public Boolean aprovado{ get; set;}
     public Materia materia{ get; set;}
     public Professor professor{get;set;}
     public Boolean alunoFazendoProva{get;set;}
     public Boolean alunoFazendoTrabalho{get;set;}
     
}