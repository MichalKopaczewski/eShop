using eShop.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Application
{
    public class BaseRequestHandler
    {
        protected IMediator Mediator;
        protected IUserAccessor UserAccessor;

        public BaseRequestHandler()
        {

        }
        public BaseRequestHandler(IUserAccessor userAccessor) : this()
        {
            this.UserAccessor = userAccessor;
        }
        public BaseRequestHandler(IMediator mediator, IUserAccessor userAccessor) : this(userAccessor)
        {
            this.Mediator = mediator;
        }
    }
}
