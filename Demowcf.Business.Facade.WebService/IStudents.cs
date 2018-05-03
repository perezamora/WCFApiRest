using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Demowcf.Business.Facade.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudents" in both code and config file together.

    [DataContract]
    public class Student
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
    }

    [ServiceContract]
    public interface IStudents
    {
        [OperationContract]
        [WebGet(UriTemplate = "/getAll", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        List<Student> GetAll();

        [OperationContract]
        [WebGet(UriTemplate = "/get/{idStudent}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        Student Get(string idStudent);

        [OperationContract]
        [WebInvoke(UriTemplate = "/create", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Student Create(Student student);

        [OperationContract]
        [WebInvoke(UriTemplate = "/update", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Student Update(Student student);

        [OperationContract]
        [WebInvoke(UriTemplate = "/delete", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST")]
        void Delete(int idStudent);
    }
}
