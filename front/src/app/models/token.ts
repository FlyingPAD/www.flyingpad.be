export interface Token
{
    token : string
}

export interface TokenCustom
{ 
    id: number, 
    firstName: string, 
    lastName: string, 
    Email: string, 
    birthdate: Date, 
    role: string, 
    exp: number, 
    iss: string, 
    aud: string 
}