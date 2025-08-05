cd /var/www/sourceexample || exit 1

echo "👉 Pulling latest code..."
git pull origin main || exit 1

echo " Remove publish old"
rm -rf publish

echo "👉 Publishing project..."
dotnet publish -c Release -o publish || exit 1

echo "👉 Killing old process..."
pkill -f SourceExample.dll || true

echo "👉 Starting app with nohup..."
nohup dotnet ./publish/SourceExample.dll > log.txt 2>&1 < /dev/null & disown

echo "✅ Deployment complete. App running in background."