# Étape 1: Construire l'application
FROM node:18 AS build
WORKDIR /www.flyingpad.be
COPY package.json package-lock.json ./
RUN npm install
COPY . ./
RUN npm run build

# Étape 2: Préparer l'image de production
FROM nginx:alpine
COPY --from=build /www.flyingpad.be/dist/flying-pad/browser /usr/share/nginx/html
COPY nginx.conf /etc/nginx/conf.d/default.conf
COPY flyingpad.front.crt /etc/ssl/certs/
COPY flyingpad.front.key /etc/ssl/private/
EXPOSE 4000 4200
CMD ["nginx", "-g", "daemon off;"]
