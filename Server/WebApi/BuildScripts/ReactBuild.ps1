cd ../../Client/template-app
yarn install
yarn build
Remove-Item "../../Server/WebApi/wwwroot/Generated" -Recurse
Copy-Item "./build" -Destination "../../Server/WebApi/wwwroot/Generated" -Recurse