namespace SwimmingCompetition.domain;

public class Validate
{
    /**
     * verific daca username ul are cel putin 8 caractere si sa nu fie formata doar din spatii albe
     * @param username = parola
     * @return True daca sunt indeplinite conditiile, altfel False
     */
    public bool validateUsername(String username){
        return !String.IsNullOrWhiteSpace(username) && username.Length > 7;
    }
    
    
    /**
     * verific daca parola are cel putin 8 caractere si sa nu fie formata doar din spatii albe
     * @param password = parola
     * @return True daca sunt indeplinite conditiile, altfel False
     */
    public bool validatePassword(String password){
        return !String.IsNullOrWhiteSpace(password) && password.Length > 7;
    }

    
    /**
     * Verific daca numele are cel putin 4 caractere si sa nu fie spatii albe
     * @param name = numele verificat
     * @return True daca numele este valid, altfel False
     */
    public bool validateName(String name){
        return !String.IsNullOrWhiteSpace(name) && name.Length > 3;
    }

    
    /**
     * Verific ca anul sa apartina intervalului (3, 100)
     * @param age = varsta verificata
     * @return True daca apartine intervalu;lui altfel False
     */
    public bool validateAge(int age){
        return age > 3 && age < 100;
    }
}