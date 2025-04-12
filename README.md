# Flying PAD Website
[www.flyingpad.be](http://www.flyingpad.be)

## Back (.NET)

- **Structure:** Clean Architecture
- **ORM:** EF Core
- **DB:** SQL Server
- **Libraries:** MediatR, AutoMapper, Fluent Validation
- **Design Patterns:** Repository, etc.
- **CQS:** Command & Query Segregation
- **GIT Strategy**
- **CI-CD:** `*.yml` files

## Front (Angular)

- **Design:** Complete Custom Design using SCSS

Since I'm already using CSS frameworks like Bootstrap, Tailwind, and Angular Material in other projects, 
I wanted to write my own CSS on this one. I think it's a great way to exercise and discover new CSS properties.

### File Structure in `./src/design/`:
- `01_normalize.scss`: Incorporates "normalize.css v8.0.1" (from [github.com/necolas/normalize.css])
- `02_global_variables.scss`: Contains global variables ( root ) for the entire project (used for theming)
- `03_global_settings.scss`: Basic global CSS configurations (html, body, etc.)

- **API Communication:** RxJS & Signal

### Installed Libraries:
- `jwt-decode`: `npm install jwt-decode`
- `ngx-pagination`: `npm install ngx-pagination` - [npmjs.com/package/ngx-pagination](https://www.npmjs.com/package/ngx-pagination)
- `ngx-toaster`: `npm install ngx-toastr`
- `ngx-cookie-service`: `npm install ngx-cookie-service`