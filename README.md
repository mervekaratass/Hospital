# Hastane Randevu Sistemi📝
Bu proje Tobeto ile gerçekleştirilen .NET & Angular Full Stack eğitiminin bitirme projesidir. 

#### GEREKSİNİMLER 🛠
- [x] Web projesi için: Asp.NET & Angular
- [x] Veri tabanı işlemleri için: MsSQL Server / PostgreSQL
- [x] Test işlemleri için: Postman,swagger vs.

#### PROJEDE KULLANILAN PROGRAMLAMA DİLLERİ VE TEKNOLOJİLER 🎯
<p>  
  <img alt="C#" src="https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=brave&logoColor=white" />
  <img alt=".NET" src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white" />
  <img alt="NArchGen" src="https://img.shields.io/badge/narchgen-%23003A70.svg?style=for-the-badge&logo=generic&logoColor=white" />
  <img alt="JWT" src="https://img.shields.io/badge/jwt-%23FFA500.svg?style=for-the-badge&logo=generic&logoColor=white" />
  <img alt="MediatR" src="https://img.shields.io/badge/mediatr-%238B008B.svg?style=for-the-badge&logo=generic&logoColor=white" />
  <img alt="AutoMapper" src="https://img.shields.io/badge/automapper-%23228B22.svg?style=for-the-badge&logo=generic&logoColor=white" />
  <img alt="SMTP" src="https://img.shields.io/badge/smtp-%2300C7B7.svg?style=for-the-badge&logo=generic&logoColor=white" />
  <img alt="Quartz" src="https://img.shields.io/badge/quartz-%237D7D7D.svg?style=for-the-badge&logo=generic&logoColor=white" />
  <img alt="Visual Studio" src="https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=brave&logoColor=white" />
  <img alt="Github" src="https://img.shields.io/badge/github-%23121011.svg?style=for-the-badge&logo=brave&logoColor=white" />  
</p>

#### 📫 NASIL BİR PROJE OLUŞTURDUK?
<p>Bu proje, hastaların randevu almasını, geçmiş ve gelecek randevularını takip etmelerini ve doktorlar ile kolayca iletişim kurmalarını sağlayan, kullanıcı dostu bir hastane randevu sistemidir. </p>

<p> Üç tip kullanıcı bulunmaktadır: </p>

➡️ 1- Admin/Yönetici 

- [x] Hasta bilgilerini listeler,düzenler ve siler. Gerektiğinde yeni hasta ekleyebilir.
- [X] Hastaneye doktor ataması yapar. Doktor bilgilerini listeler, günceller ve siler. 
- [x] Mevcut branşları listeler,düzenler ve siler. Hastaneye branş eklemesi yapar.
- [x] Geçmiş ve gelecek tüm randevu detaylarını listeler. Yeni randevu oluşturabilir.
- [x] Yazılmış raporlar detaylarını (rapor içeriği hariç) görüntüleyebilir.
- [x] Kullanıcılar tarafından oluşturulan tüm öneri & şikayet geri bildirimlerini listeler. Geri bildirimi onaylama ve silme hakkına sahiptir.
- [x] Toplam randevu sayısı, toplam doktor sayısı ve toplam branş sayısı gibi metrikleri gösteren İstatistikleri görüntüleyebilir.
- [x] Kendi bilgilerini güncelleyebilir ve şifre değişikliği yapabilir.

➡️ 2- Doktor 
- [x] Bugünkü Randevularım - Yarınki Randevularım - Çalışma Takvimim - Hasta Raporları alanlarını içeren Özet sayfasını görüntüleyebilir.
- [x] Kendi çalışma takvimini oluşturabilir. Gerektiğinde çalışma takvimini güncelleyebilir veya silebilir.
- [x] Randevulu hastalarının bilgilerini görüntüleyebilir. 
- [x] Hastaların kendisinden aldığı randevuları Geçmiş Randevular & Gelecek Randevular alanında görüntüleyebilir.
- [x] Geçmiş randevular için rapor oluşturabilir.
- [x] Oluşturduğu raporların detaylarını görüntüleyebilir.
- [x] Öneri & Şikayet için oluşturduğu geri bildirimleri görüntüleyebilir ve silebilir. 
- [x] Kendi bilgilerini güncelleyebilir.

➡️ 2- Hasta 
- [x] Bugünkü Randevularım - Gelecek Randevularım - Raporlarım - Geri Bildirimlerim alanlarını içeren Özet sayfasını görüntüleyebilir.
- [x] İstediği branş ve doktora randevu alabilir. Gerektiğinde iptal edebilir.
- [x] Aldığı randevuları Geçmiş Randevular & Gelecek Randevular alanında görüntüleyebilir.
- [x] Doktorun oluşturduğu raporların detaylarını görüntüleyebilir.
- [x] Öneri & Şikayet için oluşturduğu geri bildirimleri görüntüleyebilir ve silebilir. 
- [x] Kendi bilgilerini güncelleyebilir.


## PROJE DETAYLARI📝

✎Öncelikle projemiz bir .Net ve Angular teknolojilerini içeren bir web projesidir. Projede veritabanı olarak MsSQL, dökümantasyon olarak Swagger kullanılmıştır. Ayrıca projemizde Narchgen mimarisi kullanılarak daha yönetilebilir bir sistem oluşturulmuştur. 

🎯Projede veri tabanı bağlantı yolunu appsetting.development.json içinde yazılmıştır. Bunu yaparak uygulama içerisine bağlantı kodlarımızı yazmak yerine daha genel bir yerde kolay bir şekilde yönetilmesini sağlanmıştır. Böylece bir havuzdaki musluklar gibi hangisini istenilirse o musluktan verilerin çekilmesi sağlanmıştır.

```c#
  "AllowedHosts": "*",
  "ConnectionStrings": {  
   "BaseDb": "Server=DESKTOP-Q270QVE\\SQLEXPRESS;Database=Hospital;Trusted_Connection=True;Trust Server Certificate=True;"    
  }
```

🔒 Projemizin katmanları aşağıda gösterilmiştir:

![image](https://github.com/user-attachments/assets/46eb0125-6318-4c26-be4f-a2b17c9f318f)

-----------------------------------------------------------------------
### 🌱DOMAIN KATMANI

✎ Entityler Domain katmanında oluşturulmuştur. Aşağıda örnek olarak Branch Entity dosyasını görebilirsiniz. Her class için gereksiz kod tekrarını önlemek adına her class Entity sınıfından miras alır. Diğer entityleri projenin içerisinde inceleyebilirsiniz.

Oluşturulan Entityler

- ⚡Appointment, randevu bilgilerini tutar.
- ⚡Branch, branş bilgilerini tutar.
- ⚡Doctor, doktor bilgilerini tutar.
- ⚡DoctorSchedule, doktor çalışma takvimi bilgilerini tutar.
- ⚡EmailAuthenticator, mail doğrulama bilgilerini tutar.
- ⚡Feedback, geri bildirim bilgilerini tutar.
- ⚡Manager, yönetici bilgilerini tutar.
- ⚡OperationClaim, rol bilgilerini tutar.
- ⚡OtpAuthenticator, SMS yollama bilgilerini tutar.
- ⚡Patient, hasta bilgilerini tutar.
- ⚡RefreshToken, token bilgilerini tutar.
- ⚡Report, rapor bilgilerini tutar.
- ⚡User, kullanıcı bilgilerini tutar.
- ⚡UserOperationClaim, kullanıcı rol bilgilerini tutar.
```c#

public class Branch : Entity<int>
{
    public Branch()
    {
    }

    public Branch(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public string Name { get; set; }
    public virtual ICollection<Doctor> Doctors { get; set; }
}
```

### 🌱PERSISTENCE KATMANI

✎ Oluşturulan Entity sınıflarını veri tabanında gösterebilmek için BaseDbContext sınıfı oluşturulmuştur.Sınıfımız Narchgen tarafından sağlanan DbContext sınıfından kalıtım alarak veritabanında modellerimize karşılık gelecek olan tabloların oluşmasını sağlar.

```c#
public class BaseDbContext : DbContext
{
    protected IConfiguration Configuration { get; set; }
    public DbSet<EmailAuthenticator> EmailAuthenticators { get; set; }
    public DbSet<OperationClaim> OperationClaims { get; set; }
    public DbSet<OtpAuthenticator> OtpAuthenticators { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    public DbSet<Patient> Patients { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Branch> Branches { get; set; }
    public DbSet<Report> Reports { get; set; }

    public DbSet<Feedback> Feedbacks { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<DoctorSchedule> DoctorSchedules { get; set; }

    public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration)
        : base(dbContextOptions)
    {
        Configuration = configuration;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
```

🖋 Code First yaklaşımı ile kullanılan veri tabanı modellerini(entity) ve ilişkilerinin yapılandırılmasını sağlamak için bir yol olan Fluent Api ile modellerin konfigürasyonlarını gerçekleştirilmiştir. Örnek olarak yukarıda verilen Branch sınıfın konfigürasyon kodları gösterilmiştir.

```c#
public class BranchConfiguration : IEntityTypeConfiguration<Branch>
{
    public void Configure(EntityTypeBuilder<Branch> builder)
    {
        builder.ToTable("Branches");

        builder.Property(d => d.Id).HasColumnName("Id").IsRequired();
        builder.Property(d => d.Name).HasColumnName("Name").IsRequired();
        builder.Property(d => d.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(d => d.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(d => d.DeletedDate).HasColumnName("DeletedDate");
    }
}
```

İşlemler tamamlandıktan sonra migration işlemi yapılarak modeller veri tabanına yansıtılmıştır.
📊 Veri tabanında tablolarımı oluşturuyorum. Aşağıda oluşturulan tabloların diyagramı gösterilmiştir.

![image](https://github.com/user-attachments/assets/badeff0b-32eb-43cb-80a5-01fb2e9aba7e)
-----------------------------------------------------------------------
### 🌱APPLICATION KATMANI

🌕 Projemizde Fluent Validation ile requestler için kurallar oluşturulmuştur. Peki fluent validation nedir? Fluent Validation bir veri doğrulama kütüphanesidir. Fluent Validation ve benzeri ürünlerin kullanılması, verilerin doğru şekilde yani verilerin oluştururken konulmuş kısıtlamaları sağlayarak kurallara uyumlu halde olmasını ve kullanıcı ya da sistem kaynaklı hataların oluşmasını engeller.

📃 Bunun için Application katmanına Fluent Validation için gerekli kütüphane indirilip kurallar oluşturulmuştur.

```c#
public class CreateBranchCommandValidator : AbstractValidator<CreateBranchCommand>
{
    public CreateBranchCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty().WithMessage("İsim alanı boş olamaz.");
        RuleFor(c => c.Name).MinimumLength(5).WithMessage("İsim alanı minimum 5 karakter olmalı.");
    }
}
```
🔎 Böylece daha Controller tarafında istek atılmadan requestlerin istenilen kurallara uygun olup olmadığı kontrol edilir.

-----------------------------------------------------------------------
### 🌱WEBAPI KATMANI

⚓ Bu katmanda işlemlerin gerçekleştirildiği Controller sınıfları oluşturulur. Aşağıda BranchController dosyasının kodları örnek olarak gösterilmiştir.

```c#
[Route("api/[controller]")]
[ApiController]
public class BranchesController : BaseController
{
    [HttpPost]
    public async Task<ActionResult<CreatedBranchResponse>> Add([FromBody] CreateBranchCommand command)
    {        
        CreatedBranchResponse response = await Mediator.Send(command);

        return CreatedAtAction(nameof(GetById), new { response.Id }, response);        
    }

    [HttpPut]
    public async Task<ActionResult<UpdatedBranchResponse>> Update([FromBody] UpdateBranchCommand command)
    {       
        UpdatedBranchResponse response = await Mediator.Send(command);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<DeletedBranchResponse>> Delete([FromRoute] int id , [FromQuery] PageRequest  pageRequest)
    {        
        DeleteBranchCommand command = new() { Id = id };

        DeletedBranchResponse response = await Mediator.Send(command);

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GetByIdBranchResponse>> GetById([FromRoute] int id)
    {
        GetByIdBranchQuery query = new() { Id = id };

        GetByIdBranchResponse response = await Mediator.Send(query);

        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetListBranchQuery>> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListBranchQuery query = new() { PageRequest = pageRequest };

        GetListResponse<GetListBranchListItemDto> response = await Mediator.Send(query);


        return Ok(response);
    }


    [HttpGet("GetByName/{name}")]
    public async Task<ActionResult<GetByNameBranchResponse>> GetByName([FromRoute] string name)
    {
        GetByNameBranchQuery query = new() { Name = name };

        GetByNameBranchResponse response = await Mediator.Send(query);

        return Ok(response);
    }
}
   //diğer metotlara proje kodlarından ulaşabilirsiniz.
```

Projede 14 adet Controller sınıfı bulunmaktadır.Bunlardan bazıları Narchgen mimarisi ile hazır gelen Controller sınıfları olup aşağıda gösterilmiştir.

- ⚡ AuthController, yetkilendirme işlemlerinin gerçekleştirildiği sınıftır.
- ⚡ BaseController, diğer Controller sınıflarının miras aldığı Base yapı amacıyla kullanılır.
- ⚡ OperationClaimsController, rollerinin ayarlandığı sınıftır.
- ⚡ SmsSimulationController, SMS yollama işlemlerinin gerçekleştirildiği sınıftır.
- ⚡ UsersController, kullanıcı işlemlerinin gerçekleştirildiği sınıftır.
- ⚡ UserOperationClaimsController, kullanıcı rollerinin ayarlandığı sınıftır.
  
Proje isterlerine göre eklenen Controller sınıfları ise şunlardır;

- ⚡ AppointmentsController, randevu işlemlerinin gerçekleştirildiği sınıftır.
- ⚡ BranchesController, branş işlemlerinin gerçekleştirildiği sınıftır.
- ⚡ DoctorSchedulesController, doktor çalışma takvimi işlemlerinin gerçekleştirildiği sınıftır.
- ⚡ DoctorsController, doktor işlemlerinin gerçekleştirildiği sınıftır.
- ⚡ FeedbacksController, geri bildirim işlemlerinin gerçekleştirildiği sınıftır.
- ⚡ ManagersController, yönetici işlemlerinin gerçekleştirildiği sınıftır.
- ⚡ PatientsController, hasta işlemlerinin gerçekleştirildiği sınıftır.
- ⚡ ReportsController, rapor işlemlerinin gerçekleştirildiği sınıftır.
  
-----------------------------------------------------------------------

### 🌱PROJEMİZE EKLEDİĞİMİZ BAZI KULLANIŞLI ÖZELLİKLER:
#### ⚓ MERNİS ile TC Kimlik Numarası Doğrulama

🌕 Bu özellik, Türkiye Cumhuriyeti Kimlik Numarası (TC Kimlik No) doğrulamasını sağlamak için MERNİS (Merkezi Nüfus İdaresi Sistemi) entegrasyonunu içerir. MERNİS, Türkiye'de nüfus ve kimlik bilgilerinin yönetildiği resmi bir sistemdir. Bu entegrasyon sayesinde kullanıcıların kimlik bilgilerini doğrulayabilir ve güvenli bir şekilde kullanabiliriz. Bu entegrasyon için Application katmanına "TcKimlikNumarasi-Dogrulama" kütüphanesi indirilip projeye entegre edilmiştir. Doğrulama işlemininin sağlanması için TC Kimlik No - Ad - Soyad - Doğum Yılı bilgilerinin doğru bir şekilde girilmesi gerekmektedir. Aksi taktirde doğrulama işlemi başarısız olacaktır. Hasta Bilgileri Güncelleme kodunda bulunan mail doğrulama işlemi aşağıda örnek olarak gösterilmiştir.

```c#
  await _patientBusinessRules.ValidateNationalIdentityAndBirthYearWithMernis(request.NationalIdentity, request.FirstName, request.LastName, request.DateOfBirth.Year);
```

#### ⚓ Email Adresi Doğrulama

🌕 Bu özellik, kullanıcıların sisteme kayıt olurken sağladıkları e-posta adreslerinin doğruluğunu kontrol etmeyi amaçlar. Doğrulama işlemi, kullanıcıların iletişim bilgilerinin güncel ve geçerli olmasını sağlayarak, iletişimde ve hesap yönetiminde doğru bilgilerin kullanılmasını destekler. Hastanın sisteme kayıt olduktan sonra mail adresini doğrulama şartı eklenmiştir. Bu sayede hastanın kayıt olurken girmiş olduğu mail adresine bir doğrulama linki yollandı. Hasta bu link aracılığıyla malini doğrularsa sisteme giriş yapabilmektedir. Aksi taktirde sisteme giriş yapabilmesi mümkün olmayacaktır. Aşağıda doğrulama mailinin bir görseli bulunmaktadır:

<img alt="Email Doğrulama Ekranı" src="https://github.com/user-attachments/assets/6c7451ba-c953-4eb8-9ad1-ba962b9100f2" width="400" height="auto" />

Kullanıcı mail doğrulamasını 15 dakika içinde yapması durumunda sisteme giriş yapabilir. 15 dakikadan fazla süren doğrulama işlemleri başarısız olacaktır ve kullanıcı tekrar kayıt olmak zorundadır.

#### ⚓ Randevu Alındığında veya Mevcut Randevu İptal Edildiğinde Bilgilendirme Maili Gönderilmesi

🌕 Bu özellik, kullanıcıların randevu işlemleri üzerinde gerçekleşen değişiklikler (randevu alma veya iptal etme) durumunda otomatik olarak bilgilendirme e-postaları gönderilmesini sağlar. Kullanıcılar bu e-postalar aracılığıyla randevu durumları hakkında anlık bilgi sahibi olabilirler. MailKit kütüphanesi ve SMTP ayarları, bu özelliğin çalışması için temel altyapıyı sağlar:

----MailKit: E-posta gönderme işlemleri için kullanılan güçlü ve esnek bir .NET kütüphanesidir. MailKit, SMTP protokolü üzerinden e-posta gönderimini yönetir ve gelişmiş e-posta işlevselliği sağlar.

----SMTP Ayarları: MailKit'in kullanılabilmesi için SMTP (Simple Mail Transfer Protocol) sunucu ayarları yapılandırılır. Bu ayarlar, e-posta gönderimini sağlayan sunucunun adresi, bağlantı portu, kimlik doğrulama bilgileri gibi bilgileri içerir.

Aşağıda örnek olarak randevu alma işlemi sonrası mail gönderme kodları gösterilmiştir.

```c#
   public async Task SendAppointmentConfirmationMail(Appointment appointment)
  {
      // Mail içeriğini hazırla
      var mailMessage = new MimeMessage();
      mailMessage.From.Add(new MailboxAddress("Pair 5 Hastanesi", "fatmabireltr@gmail.com")); // Gönderen bilgisi
      appointment.Patient.Email = CryptoHelper.Decrypt(appointment.Patient.Email);
      appointment.Patient.FirstName = CryptoHelper.Decrypt(appointment.Patient.FirstName);
      appointment.Patient.LastName = CryptoHelper.Decrypt(appointment.Patient.LastName);
      appointment.Doctor.FirstName = CryptoHelper.Decrypt(appointment.Doctor.FirstName);
      appointment.Doctor.LastName = CryptoHelper.Decrypt(appointment.Doctor.LastName);

      mailMessage.To.Add(new MailboxAddress("Pair 5 Hastanesi", appointment.Patient.Email)); // Alıcı bilgisi 
      mailMessage.Subject = "Randevu Bilgilendirme"; // Mail konusu

      // HTML ve CSS içeriği oluştur
      var bodyBuilder = new BodyBuilder();
      bodyBuilder.HtmlBody = $@"
     <html>
      <head>
          <style>
              body {{ font-family: Arial, sans-serif; }}
              .container {{ border: 1px solid red; padding: 10px; }}
          </style>
      </head>
      <body>
          <div class='container'>
              <p>Sayın {appointment.Patient.FirstName} {appointment.Patient.LastName},</p>
              <p>{appointment.Date} tarihinde, saat {appointment.Time} için bir randevu aldınız.</p>
              <p>Doktor: {appointment.Doctor.Title} {appointment.Doctor.FirstName} {appointment.Doctor.LastName}</p>
              <p>Branş: {appointment.Doctor.Branch.Name}</p>
          </div>
      </body>
      </html>";

      // MimeKit'e gövdeyi ayarla
      mailMessage.Body = bodyBuilder.ToMessageBody();

      // SMTP ile bağlantı kur ve maili gönder
      using (var smtp = new SmtpClient())
      {
          smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
          smtp.Authenticate("fatmabireltr@gmail.com", "secretsmtppassword");
          await smtp.SendAsync(mailMessage);
          smtp.Disconnect(true);
      }
```

#### ⚓ Randevudan 24 Saat Önce Hatırlatma Maili Gönderilmesi

🌕 Bu özellik, kullanıcıların randevu işlemleri için otomatik hatırlatma e-postaları almasını sağlar. Infrastructure katmanına indirilen Quartz kütüphanesi kullanılarak oluşturulan zamanlayıcı, randevu tarihinden 24 saat önce e-posta gönderim işlemini başlatır. Bu sayede kullanıcılar randevularını unutmaz ve gerektiği şekilde hazırlıklarını yapabilirler. Aşağıda Quartz ayarlarının yapıldığı komutları içeren Program.cs sayfasına ait kodlar gösterilmiştir.

```c#
 builder.Services.AddQuartz(q =>
{
    q.UseMicrosoftDependencyInjectionJobFactory();
    // Job ve Trigger ekleyin
    var jobKey = new JobKey("ReminderAppointmentJob"); // Oluşturulan Reminder 
    q.AddJob<ReminderAppointmentJob>(opts => opts.WithIdentity(jobKey));
    q.AddTrigger(opts => opts
        .ForJob(jobKey)
        .WithIdentity("ReminderAppointmentJob-trigger")
        .WithCronSchedule("0 0 0 ? * *")); // Her gün 00:00'da çalışacak şekilde ayarlandı
});

```

#### ⚓ Kullanıcı Bilgilerinin Veri Tabanında Şifrelenmiş Olarak Tutulması

🌕 Bu özellik, kullanıcıların hassas bilgilerinin (ad, soyad, adres, e-posta, telefon numarası, kimlik numarası gibi) veritabanında güvenli bir şekilde saklanmasını sağlar. Bu bilgilerin şifrelenmesi, kullanıcı gizliliğini korumak ve veri güvenliğini sağlamak için önemlidir. Projede, bu şifreleme işlemi için CryptoHelper sınıfı kullanılmıştır. CryptoHelper, şifreleme algoritmalarını yönetmek ve kullanıcı bilgilerini güvenli bir şekilde saklamak için kullanılır. Aşağıda hasta bilgilerinin şifrelenme işlemi gösterilmiştir:

```c#
 public async Task<UpdatedPatientResponse> Handle(UpdatePatientCommand request, CancellationToken cancellationToken)
 {
     //MERNIS VALIDATION
     await _patientBusinessRules.ValidateNationalIdentityAndBirthYearWithMernis(request.NationalIdentity, request.FirstName, request.LastName, request.DateOfBirth.Year);

     Patient? patient = await _patientRepository.GetAsync(predicate: p => p.Id == request.Id, cancellationToken: cancellationToken);
     await _patientBusinessRules.PatientShouldExistWhenSelected(patient);

     patient = _mapper.Map(request, patient);

    //ENCRYPT informations
     patient.FirstName = CryptoHelper.Encrypt(patient.FirstName);
     patient.LastName = CryptoHelper.Encrypt(patient.LastName);
     patient.NationalIdentity = CryptoHelper.Encrypt(patient.NationalIdentity);
     patient.Phone = CryptoHelper.Encrypt(patient.Phone);
     patient.Address = CryptoHelper.Encrypt(patient.Address);
     patient.Email = CryptoHelper.Encrypt(patient.Email);

     await _patientBusinessRules.UserNationalIdentityShouldBeNotExists(patient.Id,patient.NationalIdentity);
     await _patientRepository.UpdateAsync(patient!);

     UpdatedPatientResponse response = _mapper.Map<UpdatedPatientResponse>(patient);
     return response;
 }

```
-----------------------------------------------------------------------
Anlatacaklarım bu kadar. Umarım açık olmuştur. 🧕🏻 Görüşürüz 🎉

## Badges

Add badges from somewhere like: [shields.io](https://shields.io/)

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![GPLv3 License](https://img.shields.io/badge/License-GPL%20v3-yellow.svg)](https://opensource.org/licenses/)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](http://www.gnu.org/licenses/agpl-3.0)
