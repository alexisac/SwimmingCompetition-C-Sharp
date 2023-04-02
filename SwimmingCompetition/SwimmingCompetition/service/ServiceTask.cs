using SwimmingCompetition.repository;
using SwimmingCompetition.domain;

namespace SwimmingCompetition.service;

public class ServiceTask
{
    private RepoBDTask rt;


    public ServiceTask(RepoBDTask rt) {
        this.rt = rt;
    }

    public MyTask findOne(int idTask){
        return rt.findOne(idTask);
    }

    public int ifExistTask(int distance, String style)
    {
        return rt.ifExistTask(new MyTask(convertDistanceToEnum(distance), convertStyleToEnum(style)));
    }
    public List<MyTask> findAll(){
        return rt.findAll();
    }
    
    
    private Utility.enumDistance convertDistanceToEnum(int distance)
    {
        return distance switch
        {
            50 => Utility.enumDistance.A,
            200 => Utility.enumDistance.B,
            800 => Utility.enumDistance.C,
            _ => Utility.enumDistance.D
        };
    }
    
    private Utility.enumStyle convertStyleToEnum(string style)
    {
        return style switch
        {
            "MIXT" => Utility.enumStyle.MIXT,
            "BUTTERFLY" => Utility.enumStyle.BUTTERFLY,
            "BACKSTROKE" => Utility.enumStyle.BACKSTROKE,
            _ => Utility.enumStyle.FREESTYLE
        };
    }
}