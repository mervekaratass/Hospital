using Application.Features.Reports.Constants;
using Application.Features.Reports.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.Reports.Constants.ReportsOperationClaims;
using Application.Features.Doctors.Constants;
using Microsoft.EntityFrameworkCore;
using Application.Features.Patients.Constants;

namespace Application.Features.Reports.Queries.GetById;

public class GetByIdReportQuery : IRequest<GetByIdReportResponse>, ISecuredRequest
{
    public int Id { get; set; }

    public string[] Roles => [Admin, Read, DoctorsOperationClaims.Update, PatientsOperationClaims.Update];

    public class GetByIdReportQueryHandler : IRequestHandler<GetByIdReportQuery, GetByIdReportResponse>
    {
        private readonly IMapper _mapper;
        private readonly IReportRepository _reportRepository;
        private readonly ReportBusinessRules _reportBusinessRules;

        public GetByIdReportQueryHandler(IMapper mapper, IReportRepository reportRepository, ReportBusinessRules reportBusinessRules)
        {
            _mapper = mapper;
            _reportRepository = reportRepository;
            _reportBusinessRules = reportBusinessRules;
        }

        public async Task<GetByIdReportResponse> Handle(GetByIdReportQuery request, CancellationToken cancellationToken)
        {
            Report? report = await _reportRepository.GetAsync(predicate: r => r.Id == request.Id &&r.DeletedDate==null , include:x=>x.Include(x=>x.Appointment).Include(x=>x.Appointment.Patient).Include(x=>x.Appointment.Doctor),
                cancellationToken: cancellationToken);
            await _reportBusinessRules.ReportShouldExistWhenSelected(report);



            GetByIdReportResponse response = _mapper.Map<GetByIdReportResponse>(report);
            
            return response;
        }
    }
}