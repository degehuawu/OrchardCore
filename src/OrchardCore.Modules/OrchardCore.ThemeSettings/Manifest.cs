using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Theme Settings",
    Author = "The Orchard Core Team",
    Website = "https://orcharcore.net",
    Version = "2.0.0",
    Description = "Theme Settings.",
    Dependencies = new[] { "OrchardCore.Admin" },
    Category = "Theming"
)]