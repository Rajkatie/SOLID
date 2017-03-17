using System;

namespace SRP
{
    public interface IEmail
    {

        void setSender(String sender);
        void setReceiver(String receiver);
        void setContent(String content);
    }
}



