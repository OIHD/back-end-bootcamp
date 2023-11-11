
**Automapper**, .NET uygulamalarında sınıflar arasında veri eşlemesini (mapping) otomatikleştirmek için kullanılan bir kütüphanedir.
    

*Örnek kullanım:*

    Mapper.Initialize(cfg => {  
    cfg.CreateMap<Source, Target>();  
    });
    
    Target target = Mapper.Map<Source, Target>(source);

Böylece Source ve Target sınıfları arasında otomatik eşleme gerçekleşmiş olur.
