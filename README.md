/FULLSTACKAPP
│
├── ClientApp/                 # Blazor WebAssembly frontend
│   ├── Pages/                 # UI components (FetchProduct, Home, etc.)
│   ├── wwwroot/               # Static assets
│   ├── Program.cs             # WASM startup
│   └── ClientApp.csproj
│
├── ServerApp/                 # Blazor Server + Minimal API backend
│   ├── Data/                  # ProductData.cs (static product list)
│   ├── Models/                # Product.cs, Category.cs
│   ├── Program.cs             # API endpoints + caching + CORS
│   ├── appsettings.json
│   └── ServerApp.csproj
│
└── FullStackSolutionDotnet.sln

How to run Project:
Step 1 : Run ServerApp and make sure it will host on port 5044 , this is port where client will listen to
Step 2 : Run ClientApp and open the link of its localhost.
To add more product data, please add them in ServerApp/Data/ProductData.cs

Project Features :
* Using Middleware CORS on ServerApp for Client calling API . Rules allow to any.
* Using Caching Service which will cache API call every 5 mins

Copilot Assisstance:
During creating this project, beside the instructions from the courses, Copilot helped me 
1. Implement CORS to allow ClientApp communicate with ServerApp
2. Deserializing nested Json Structure
3. Implement Caching Service for preventing redundant API call
4. Optimize my code for better performance and comprehensive layout.
