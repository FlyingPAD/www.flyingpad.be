# Flying PAD Website

[www.flyingpad.be](http://www.flyingpad.be) (Satellit Case Study)

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
- **Micro-Services / BFF:** Exloring Potential

## Front (Angular)

### Objectives:
- **Design:** Complete Custom Design using SCSS
- **Modular Structure:** Using Angular Modules
- **API Communication:** Exploring RxJS & Signal

### DESIGN (SCSS):
Files located in `./src/design/`.  
Read `design-README.txt` for Design Documentation.

### Modules:
Located in `./src/app`:

- `app`: The Main Module & Entry Point (Main Routing, Router Outlet, Initialization (Token, GetData) & Refresh (F5))
- `core`: The Core Application Module (Components, Interceptor, Layouts, Models, Services)
- `shared`: The Shared Module (Components, Pipes, Forms, ...)
- `**`: Feature Module (Artists & Styles, Franchises & Medias, Links, Models, ...)

### Services:

- `MenuService`: which handles Menu (Desktop & Mobile Behavior)
- WIP (Work In Progress...)
- Common client-http request services

### Installed Libraries:

- `jwt-decode`: `npm install jwt-decode`
- `ngx-pagination`: `npm install ngx-pagination` - [npmjs.com/package/ngx-pagination](https://www.npmjs.com/package/ngx-pagination)
- `ngx-toaster`: `npm install ngx-toastr`
- `ngx-cookie-service`: `npm install ngx-cookie-service`
