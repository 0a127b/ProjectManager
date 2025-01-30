Dokumentacja Projektu - ProjectManager
1. Instalacja
Wymagania systemowe:
- .NET SDK 9.0 (lub wyższy)
- SQL Server (lub inna kompatybilna baza danych)
- Visual Studio 2022 (opcjonalnie)
Kroki instalacji:
1. Pobierz kod źródłowy i umieść folder `ProjectManager` w dogodnej lokalizacji.
2. Otwórz projekt w Visual Studio (`ProjectManager.sln`).
3. Zainstaluj zależności:
dotnet restore
4. Ustaw konfigurację bazy danych (patrz sekcja Konfiguracja).
5. Zastosuj migracje bazy danych:
dotnet ef database update
6. Uruchom aplikację:
dotnet run
2. Wymagania
Wymaganie	Wersja
 .NET SDK	9.0+
 SQL Server	2019+
 Visual Studio (opcjonalnie)	2022+
 Entity Framework Core	7.0+
3. Konfiguracja
Połączenie z bazą danych
Plik `appsettings.json` zawiera domyślną konfigurację bazy danych:

"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=ProjectManagerDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}

Testowe konta użytkowników
Rola	Login	Hasło
Admin	admin@example.com	Admin123!
Użytkownik	user@example.com	User123!
4. Opis działania aplikacji
Logowanie/Rejestracja:
1. Użytkownik rejestruje się poprzez `Account/Register`.
2. Po rejestracji może zalogować się (`Account/Login`).
3. Administrator ma dostęp do panelu zarządzania użytkownikami.
Zarządzanie projektami:
1. Po zalogowaniu użytkownik może tworzyć projekty (`Projects/Create`).
2. Projekty są wyświetlane w `Projects/Index`.
3. Każdy projekt może mieć kategorie (`Categories/`) oraz komentarze (`Comments/`).
Uprawnienia:
- Admin: Może tworzyć, edytować i usuwać dowolne projekty oraz użytkowników.
- Użytkownik: Może zarządzać tylko swoimi projektami.
Dodatkowe uwagi:
- Aplikacja korzysta z Bootstrap i jQuery do stylizacji oraz walidacji formularzy.
- Widoki są oparte na Razor Pages (`Views/`).
- API dostępne pod `/Api/ProjectsApiController`.
