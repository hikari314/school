package br.test;

public class Share {
    //main
    private static String name;
    public void setName(String y) {
        name = y;
    }
    public String getName(){
        return name;
    }

    //w1
    private static String A;
    public void setA(String w){
        A = w;
    }
    public String getA(){
        return A;
    }

    //w2
    private static String S;
    public void setS(String k){
        S = k;
    }
    public String getS(){
        return S;
    }

    //w3
    private static String P;
    public void setP(String i){
        P = i;
    }
    public String getP(){
        return P;
    }

    //w4
    private static String E;
    public void setE(String u){
        E = u;
    }
    public String getE(){
        return E;
    }

    //w5
    private static String T;
    public void setT(String f){
        T = f;
    }
    public String getT(){
        return T;
    }

    //final
    private int points = 0;
    public int count(){
        if (A == "y"){ points ++; }
        if (S == "y"){ points ++; }
        if (P == "y"){ points ++; }
        if (E == "y"){ points ++; }
        if (T == "y"){ points ++; }
        return points;
    }
}

