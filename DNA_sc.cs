using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA_sc 
   {
    List<int> genes=new List<int>();
    int maxValue=0, dnaLength=0;
    public DNA_sc(int max_value,int dna_length)
    {
        this.maxValue=max_value;
        this.dnaLength=dna_length;
        SetRandom();
    }
    public void SetRandom(){
        genes.Clear();
        for(int i=0;i<dnaLength;i++){
            genes.Add(Random.Range(0,maxValue));

        }
    }

    public void SetInt(int value,int pos){
        genes[pos] = value;
    }

    public int GetGene(int pos){
        return genes[pos];
    }

    public void Combine(DNA_sc dna1,DNA_sc dna2){
        for(int i=0;i<dnaLength;i++){
            if(i<dnaLength/2.0)
            genes[i] = dna1.genes[i];
            else
            genes[i] = dna2.genes[i];
        }
    }

    public void Mutate(){
        genes[Random.Range(0,dnaLength)]=Random.Range(0,maxValue);
    }
   }
