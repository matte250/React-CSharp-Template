cd ../../Client/template-app
yarn build
Remove-Item "../../Server/WebApi/wwwroot/Generated" -Recurse
Copy-Item "./build" -Destination "../../Server/WebApi/wwwroot/Generated" -Recurse