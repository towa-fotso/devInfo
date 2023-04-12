class chat1{
    public string nom;
    public string couleur;
    public int age;
    public chat1(string nom, string couleur, int age){
        this.nom = nom;
        this.couleur = couleur;
        this.age = age;
    }
    public void miauler(){
        Console.WriteLine("Miaou");
    }
}

class Dauphin1{
    public string nom;
    public string couleur;
    public int age;
    public Dauphin1(string nom, string couleur, int age){
        this.nom = nom;
        this.couleur = couleur;
        this.age = age;
    }
    public void nager(){
        Console.WriteLine("Je nage");
    }
}