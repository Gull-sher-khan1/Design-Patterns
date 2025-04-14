using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        Object Execute(Object request);
    }

    public abstract class AbstractHandler: IHandler
    {
        protected IHandler _next_handler;

        public IHandler SetNext(IHandler handler)
        {
            _next_handler = handler;
            return handler;
        }

        public virtual Object Execute(Object request) 
        {
            if (_next_handler != null) 
            {
                return _next_handler.Execute(request);
            }
            else
            {
                return "It does not fit";
            }
        }
    }

    public class SquareHoleHandler : AbstractHandler
    {
        public override Object Execute(Object request)
        {
            if ((string)request == "square")
            {
                return "SquareHole: It Fits";
            }
            else
            {
                return base.Execute(request);
            }
        }
    }

    public class CircleHoleHandler : AbstractHandler
    {
        public override Object Execute(Object request)
        {
            if ((string)request == "circle")
            {
                return "CircleHole: It Fits";
            }
            else
            {
                return base.Execute(request);
            }
        }
    }

    public class TriangleHoleHandler : AbstractHandler
    {
        public override Object Execute(Object request)
        {
            if ((string)request == "triangle")
            {
                return "TriangleHole: It Fits";
            }
            else
            {
                return base.Execute(request);
            }
        }
    }

}
