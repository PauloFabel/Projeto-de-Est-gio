using System;
public class Professor : Pessoa{
    public double salario{ get; set;}
    public int diaTrabalhados{ get; set;}

    public double horastrabalhadas{ get; set;}
    public Aluno aluno{ get; set;}
    public Boolean provaAutorizada{get;set;}
    public Boolean trabalhoAutorizado{get;set;}

    public double notaAtribuida{get;set;} 
    
}