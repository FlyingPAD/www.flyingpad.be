# Flying PAD Website

**Website CI-CD:** [www.flyingpad.be](http://www.flyingpad.be) (Satellit Case Study)

## Back ( .NET )

### Objectives:
- **Structure:** Clean Architecture
- **ORM:** EF Core
- **Libraries:** MediatR, AutoMapper, Fluent Validation
- **Design Patterns:** Repository, etc.
- **CQS:** Command / Query Segregation
- **GIT Strategy**
- **CI-CD:** `*.yml` files
- **Docker Containers & Kubernetes Orchestration**
- **Micro-Services / BFF:** Maybe Later XD

## Front (Angular)

### DESIGN (SCSS):
Files located in `./src/design/`.  
Read `design-README.txt` for Design Documentation.

### MODULES:
Located in `./src/app`:

- `app`: The Main Module & Entry Point (Main Routing, Router Outlet, Initialization (Token, GetData) & Refresh (F5))
- `core`: The Core Application Module (Components, Interceptor, Layouts, Models, Services)
- `shared`: The Shared Module (Components, Pipes, Forms, ...)
- `**`: Feature Module (Artists & Styles, Franchises & Medias, Links, Models, ...)

### SERVICES:

- `MenuService`: which handles Menu (Desktop & Mobile Behavior)
- WIP (Work In Progress...)
- Common client-http request services

### Installed Libraries:

- `jwt-decode`: `npm install jwt-decode`
- `ngx-pagination`: `npm install ngx-pagination` - [npmjs.com/package/ngx-pagination](https://www.npmjs.com/package/ngx-pagination)
- `ngx-toaster`: `npm install ngx-toastr`
- `ngx-cookie-service`: `npm install ngx-cookie-service`
