using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Domain.Models
{
    public class OperationResult
    {
        public bool Success { get; private set; }
        public string OperationName { get; private set; }
        public string Message { get; private set; }
        public string ExMessage { get; private set; }
        public DateTime OperationDate { get; private set; }
        public HttpStatusCode Status { get; private set; }
        public object ReturnObject { get; private set; }
        public OperationResult(string OperationName)
        {
            this.Success = false;
            this.OperationName = OperationName;
            this.OperationDate = DateTime.Now;
        }
        public OperationResult Succeed(string Message)
        {
            this.Success = true;
            this.Message = Message;
            this.Status = HttpStatusCode.OK;
            return this;
        }
        public OperationResult Succeed(string Message, HttpStatusCode Status)
        {
            this.Success = true;
            this.Message = Message;
            this.Status = Status;
            return this;
        }
        public OperationResult Succeed(string Message, object ReturnObject)
        {
            this.Success = true;
            this.Message = Message;
            this.Status = HttpStatusCode.OK;
            this.ReturnObject = ReturnObject;
            return this;
        }
        public OperationResult Succeed(string Message, HttpStatusCode Status, object ReturnObject)
        {
            this.Success = true;
            this.Message = Message;
            this.Status = Status;
            this.ReturnObject = ReturnObject;
            return this;
        }
        public OperationResult Failed(string Message)
        {
            this.Success = false;
            this.Message = Message;
            this.Status = HttpStatusCode.BadRequest;
            return this;
        }
        public OperationResult Failed(string Message, string ExMessage)
        {
            this.Success = false;
            this.Message = Message;
            this.ExMessage = ExMessage;
            this.Status = HttpStatusCode.BadRequest;
            return this;
        }
        public OperationResult Failed(string Message, object ReturnObject)
        {
            this.Success = false;
            this.Message = Message;
            this.ReturnObject = ReturnObject;
            this.Status = HttpStatusCode.BadRequest;
            return this;
        }
        public OperationResult Failed(string Message, string ExMessage, object ReturnObject)
        {
            this.Success = false;
            this.Message = Message;
            this.ExMessage = ExMessage;
            this.ReturnObject = ReturnObject;
            this.Status = HttpStatusCode.BadRequest;
            return this;
        }
        public OperationResult Failed(string Message, HttpStatusCode Status)
        {
            this.Success = false;
            this.Message = Message;
            this.Status = Status;
            return this;
        }
        public OperationResult Failed(string Message, HttpStatusCode Status, object ReturnObject)
        {
            this.Success = false;
            this.Message = Message;
            this.Status = Status;
            this.ReturnObject = ReturnObject;
            return this;
        }
        public OperationResult Failed(string Message, string ExMessage, HttpStatusCode Status)
        {
            this.Success = false;
            this.Message = Message;
            this.ExMessage = ExMessage;
            this.Status = Status;
            return this;
        }
        public OperationResult Failed(string Message, string ExMessage, HttpStatusCode Status, object ReturnObject)
        {
            this.Success = false;
            this.Message = Message;
            this.ExMessage = ExMessage;
            this.Status = Status;
            this.ReturnObject = ReturnObject;
            return this;
        }
    }
}
