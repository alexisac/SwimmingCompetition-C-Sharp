using SwimmingCompetition.repository;
using SwimmingCompetition.domain;

namespace SwimmingCompetition.service;

public class ServiceAccount
{
    private RepoBDAccount repoAC;
    private Validate v;


    private int giveNewId()
    {
        List<int> vect = new List<int>();
        foreach (Account a in repoAC.findAll()){
            vect.Add(a.id);
        }
        vect.Sort();
        bool gasit = false;
        int id = 1;
        int i = 0;
        while (!gasit && i < vect.Count){
            if (id == vect[i]){
                i++;
                id++;
            }
            else
            {
                gasit = true;
            }
        }
        return id;
    }


    public ServiceAccount(RepoBDAccount repoAc, Validate v)
    {
        repoAC = repoAc;
        this.v = v;
    }

    public int ifExistAccount(String username, String password) {
        return repoAC.ifExistAccount(new Account(username, password));
    }

    public void add(String username, String password)
    {
        if(v.validateUsername(username) && v.validatePassword(password)){
            Account a = new Account(username, password);
            a.id = giveNewId();
            repoAC.add(a);
        } else {
            if(!v.validateUsername(username) && !v.validatePassword(password)) {
                throw new ServiceException("Username and password are wrong!");
            } else if (!v.validateUsername(username)){
                throw new ServiceException("Username is wrong!");
            } else {
                throw new ServiceException("Password is wrong!");
            }
        }
    }

    public Account findOne(int id)
    {
        return repoAC.findOne(id);
    }
}