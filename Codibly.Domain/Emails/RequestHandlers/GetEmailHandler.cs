﻿using Codibly.Domain.Emails.Model;
using Codibly.Domain.Emails.Repositories;
using Codibly.Domain.Emails.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Codibly.Domain.Emails.RequestHandlers
{
    public class GetEmailHandler : IRequestHandler<GetEmail, EmailModel>
    {
        private readonly IEmailsRepository emailsRepository;

        public GetEmailHandler(IEmailsRepository emailsRepository)
        {
            this.emailsRepository = emailsRepository;
        }

        public async Task<EmailModel> Handle(GetEmail request, CancellationToken cancellationToken)
        {
            return await emailsRepository.GetEmail(request.Id, cancellationToken);
        }
    }
}
